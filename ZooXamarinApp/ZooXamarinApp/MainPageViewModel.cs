using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;
using ZooModels;

namespace ZooXamarinApp {
    class MainPageViewModel {
        public Zoo Zoo { get; set; }
        private int interval = 500;
        public int Interval {
            get { return interval; }
            set { interval = value; if(timerEnabled) StartTimer(Interval); }
        }
        private bool timerEnabled = false;

        public Command AddAnimalCmd { get; set; }
        public Command FeedAnimalsCmd { get; set; }
        public Command StartStopCmd { get; set; }
        public Command StepCmd { get; set; }

        public MainPageViewModel() {
            Zoo = new Zoo();

            AddAnimalCmd = new Command<Type>(animalType => AddAnimal(animalType));
            FeedAnimalsCmd = new Command<Type>(animalType => FeedAnimals(animalType));
            StartStopCmd = new Command(Start);
            StepCmd = new Command(Step, () => !timerEnabled);

        } 

        private void Start() {
            if (timerEnabled) {
                timerEnabled = false;
            } else {
                timerEnabled = true;
                StartTimer(Interval);
            }

            StepCmd.ChangeCanExecute();
        }

        private void StartTimer(int interval) {
            Device.StartTimer(new TimeSpan(0, 0, 0, 0, interval), () => {
                Step();
                return timerEnabled;
            });
        }

        private void Step() {
            Zoo.ElapseTime();

            if (Zoo.Animals.Count == 0)
                Start();
        }

        private void AddAnimal(Type animalType) {
            Zoo.AddAnimal(animalType);
        }

        private void FeedAnimals(Type animalType) {
            Zoo.FeedAnimals<animalType>();
        }
    }
}
