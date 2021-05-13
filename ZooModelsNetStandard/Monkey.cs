using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooModels {
    public sealed class Monkey : Animal {
        public Monkey() {
            Name = "Monkey";
            Energy = 60;
        }

        public override void Eat() {
            Energy += 10;
        }

        public override void UseEnergy() {
            Energy -= 2;
        }
    }
}
