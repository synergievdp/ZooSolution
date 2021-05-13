using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooModels {
    public sealed class Elephant : Animal {

        public Elephant() {
            Name = "Elephant";
        }

        public override void Eat() {
            Energy += 50;
        }
        public override void UseEnergy() {
            Energy -= 5;
        }
    }
}
