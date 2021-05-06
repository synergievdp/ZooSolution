using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using ZooModels;

namespace ZooWPFApp {
    class MainWindowViewModel {
        public Zoo Zoo { get; set; }
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
            Zoo = new();
            timer = new();
            timer.Tick += Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, Interval);

            AddAnimalCmd = new(animalType => AddAnimal((Type)animalType));
            FeedAnimalsCmd = new(animalType => FeedAnimals((Type)animalType));
            StartStopCmd = new(_ => StartStop());
            StepCmd = new(_ => Tick(null, EventArgs.Empty), _ => !timer.IsEnabled);
        }

        private void Tick(object sender, EventArgs e) {
            Zoo.ElapseTime();

            if (Zoo.Animals.Count == 0)
                StartStop();
        }

        private void StartStop() {
            if (timer.IsEnabled)
                timer.Stop();
            else
                timer.Start();

            StepCmd.RaiseCanExecuteChanged();
        }

        private void AddAnimal(Type animalType) {
            Debug.WriteLine(animalType);

            Zoo.AddAnimal(animalType);
        }
        private void FeedAnimals(Type animalType) {
            Debug.WriteLine(animalType);

            Zoo.FeedAnimals(animalType);
        }
    }
}
