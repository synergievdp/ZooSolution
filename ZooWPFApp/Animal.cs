using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooWPFApp {
    public abstract class Animal {
        public string Name { get; set; }
        public int Energy { get; set; } = 100;

        public virtual void Eat() {
            Energy += 25;
        }

        public abstract void UseEnergy();
    }
}
