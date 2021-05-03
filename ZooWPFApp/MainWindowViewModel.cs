using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ZooWPFApp {
    class MainWindowViewModel {
        public ObservableCollection<Animal> Animals { get; set; }
        private int interval = 500;
        public int Interval {
            get { return interval; }
            set {
                interval = value;
                timer.Interval = timer.Interval.TotalMilliseconds != interval ? new TimeSpan(0, 0, 0, 0, Interval) : timer.Interval;
            }
        }
        DispatcherTimer timer;

        public RelayCommand AddAnimalCmd { get; set; }
        public RelayCommand FeedAnimalsCmd { get; set; }
        public RelayCommand StartStopCmd { get; set; }
        public RelayCommand StepCmd { get; set; }

        public MainWindowViewModel() {
            Animals = new();
            timer = new();
            timer.Tick += Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, Interval);

            AddAnimalCmd = new(animalType => AddAnimal((Type)animalType));
            FeedAnimalsCmd = new(animalType => FeedAnimals((Type)animalType));
            StartStopCmd = new(_ => StartStop());
            StepCmd = new(_ => Tick(null, EventArgs.Empty), _ => !timer.IsEnabled);
        }

        private void Tick(object sender, EventArgs e) {
            foreach(Animal animal in Animals.ToList()) {
                animal.UseEnergy();
                Debug.WriteLine($"{animal.Name} ({animal.Energy})");
                if (animal.Energy < 0)
                    Animals.Remove(animal);
            }

            if (Animals.Count == 0)
                StartStop();
        }

        private void StartStop() {
            if (timer.IsEnabled)
                timer.Stop();
            else
                timer.Start();

            StepCmd.RaiseCanExecuteChanged();
        }

        private void AddAnimal(Type animal) {
            Debug.WriteLine(animal);

            if (animal == typeof(Monkey))
                Animals.Add(new Monkey());
            else if (animal == typeof(Lion))
                Animals.Add(new Lion());
            else if (animal == typeof(Elephant))
                Animals.Add(new Elephant());
        }
        private void FeedAnimals(Type animalType) {
            Debug.WriteLine(animalType);

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
