using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooModels {
    public class Zoo {
        public ObservableCollection<Animal> Animals { get; set; }

        public Zoo() {
            Animals = new();
        }

        public void ElapseTime() {
            foreach (Animal animal in Animals.ToList()) {
                animal.UseEnergy();
                if (animal.Energy <= 0)
                    Animals.Remove(animal);
            }
        }

        public void AddAnimal(Type animalType) {
            if (animalType == typeof(Monkey))
                Animals.Add(new Monkey());
            else if (animalType == typeof(Lion))
                Animals.Add(new Lion());
            else if (animalType == typeof(Elephant))
                Animals.Add(new Elephant());
        }

        public void FeedAnimals(Type animalType) {
            if (animalType == typeof(Monkey))
                foreach (Animal monkey in Animals.OfType<Monkey>())
                    monkey.Eat();
            else if (animalType == typeof(Lion))
                foreach (Animal lion in Animals.OfType<Lion>())
                    lion.Eat();
            else if (animalType == typeof(Elephant))
                foreach (Animal elephant in Animals.OfType<Elephant>())
                    elephant.Eat();
            else if (animalType == typeof(Animal))
                foreach (Animal animal in Animals)
                    animal.Eat();
        }
    }
}
