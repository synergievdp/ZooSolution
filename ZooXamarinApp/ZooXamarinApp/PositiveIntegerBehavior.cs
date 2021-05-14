using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ZooXamarinApp {
    public class PositiveIntegerBehavior : Behavior<Entry> {
        protected override void OnAttachedTo(Entry bindable) {
            bindable.TextChanged += OnTextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable) {
            bindable.TextChanged -= OnTextChanged;
            base.OnDetachingFrom(bindable);
        }

        void OnTextChanged(object sender, TextChangedEventArgs e) {
            if (sender is Entry entry) {
                string text = entry.Text;
                bool valid = !String.IsNullOrWhiteSpace(text) && text.All(c => char.IsDigit(c));

                entry.Text = valid? e.NewTextValue : e.OldTextValue;
            }
        }
    }
}
