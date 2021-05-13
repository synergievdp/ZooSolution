using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooModels {
    public abstract class Animal : INotifyPropertyChanged {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }
        private int energy;
        public int Energy {
            get { return energy; }
            set { energy = value; OnPropertyChanged(); }
        }

        public Animal() {
            Energy = 100;
        }

        public virtual void Eat() {
            Energy += 25;
        }

        public abstract void UseEnergy();
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string name = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
