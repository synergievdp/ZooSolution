using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooModels {
    public sealed class Lion : Animal {

        public Lion() {
            Name = "Lion";
        }

        public override void Eat() {
            Energy += 25;
        }
        public override void UseEnergy() {
            Energy -= 10;
        }
    }
}
