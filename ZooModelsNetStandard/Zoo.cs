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
            Animals = new ObservableCollection<Animal>();
        }

        public void ElapseTime() {
            foreach (Animal animal in Animals.ToList()) {
                animal.UseEnergy();
                if (animal.Energy <= 0)
                    Animals.Remove(animal);
            }
        }

        public void AddAnimal(Type animalType) {
            if(Activator.CreateInstance(animalType) is Animal animal)
                Animals.Add(animal);
        }

        public void FeedAnimals(Type animalType) {
            foreach (Animal animal in Animals.OfType<animalType>()) {
                animal.Eat();
            }
        }
    }
}
