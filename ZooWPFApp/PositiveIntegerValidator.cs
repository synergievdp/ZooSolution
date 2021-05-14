using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ZooWPFApp {
    class PositiveIntegerValidator : ValidationRule {
            public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
                if ((value as string).All(c => char.IsDigit(c))) {
                    return ValidationResult.ValidResult;
                } else
                    return new ValidationResult(false, "Only digits allowed");
            }
    }
}
