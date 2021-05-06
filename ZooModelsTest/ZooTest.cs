using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ZooModels;

namespace ZooModelsTest {
    [TestClass]
    public class ZooTest {

        #region ElapseTime
        [TestMethod]
        public void TestElapseTime() {
            Zoo zoo = new();
            zoo.AddAnimal(typeof(Monkey));
            List<Animal> list = new(zoo.Animals);

            zoo.ElapseTime();

            CollectionAssert.AreEqual(list, zoo.Animals);
        }
        [TestMethod]
        public void TestElapseTimeIfBelowZeroEnergy() {
            Zoo zoo = new();
            zoo.AddAnimal(typeof(Monkey));

            zoo.Animals[0].Energy = -1;
            zoo.ElapseTime();

            CollectionAssert.AreEqual(new List<Animal>(), zoo.Animals);
        }

        [TestMethod]
        public void TestElapseTimeIfZeroEnergy() {
            Zoo zoo = new();
            zoo.AddAnimal(typeof(Monkey));

            zoo.Animals[0].Energy = 0;
            zoo.ElapseTime();

            CollectionAssert.AreEqual(new List<Animal>(), zoo.Animals);
        }

        [TestMethod]
        public void TestElapseTimeIfNoAnimals() {
            Zoo zoo = new();

            zoo.ElapseTime();

            CollectionAssert.AreEqual(new List<Animal>(), zoo.Animals);
        }
        #endregion

        #region AddAnimal
        [TestMethod]
        public void TestAddAnimalMonkey() {
            Zoo zoo = new();

            zoo.AddAnimal(typeof(Monkey));

            Assert.IsTrue(zoo.Animals[0].GetType() == typeof(Monkey));
        }
        [TestMethod]
        public void TestAddAnimalLion() {
            Zoo zoo = new();

            zoo.AddAnimal(typeof(Lion));

            Assert.IsTrue(zoo.Animals[0].GetType() == typeof(Lion));
        }
        [TestMethod]
        public void TestAddAnimalElephant() {
            Zoo zoo = new();

            zoo.AddAnimal(typeof(Elephant));

            Assert.IsTrue(zoo.Animals[0].GetType() == typeof(Elephant));
        }

        [TestMethod]
        public void TestAddAnimalIsNull() {
            Zoo zoo = new();

            zoo.AddAnimal(null);

            CollectionAssert.AreEqual(new List<Animal>(), zoo.Animals);
        }

        [TestMethod]
        public void TestAddAnimalInvalid() {
            Zoo zoo = new();

            zoo.AddAnimal(typeof(Animal));

            CollectionAssert.AreEqual(new List<Animal>(), zoo.Animals);
        }
        #endregion

        #region FeedAnimals
        [TestMethod]
        public void TestFeedAnimals() {
            Zoo zoo = new();
            zoo.AddAnimal(typeof(Monkey));
            zoo.AddAnimal(typeof(Lion));
            zoo.AddAnimal(typeof(Elephant));

            zoo.FeedAnimals(typeof(Animal));

            bool monkey = zoo.Animals[0].Energy > 60;
            bool lion = zoo.Animals[1].Energy > 100;
            bool elephant = zoo.Animals[2].Energy > 100;

            Assert.IsTrue(monkey && lion && elephant);
        }

        [TestMethod]
        public void TestFeedMonkeys() {
            Zoo zoo = new();
            zoo.AddAnimal(typeof(Monkey));
            zoo.AddAnimal(typeof(Lion));
            zoo.AddAnimal(typeof(Elephant));

            zoo.FeedAnimals(typeof(Monkey));

            bool monkey = zoo.Animals[0].Energy > 60;
            bool lion = zoo.Animals[1].Energy > 100;
            bool elephant = zoo.Animals[2].Energy > 100;

            Assert.IsTrue(monkey && !lion && !elephant);
        }

        [TestMethod]
        public void TestFeedLions() {
            Zoo zoo = new();
            zoo.AddAnimal(typeof(Monkey));
            zoo.AddAnimal(typeof(Lion));
            zoo.AddAnimal(typeof(Elephant));

            zoo.FeedAnimals(typeof(Lion));

            bool monkey = zoo.Animals[0].Energy > 60;
            bool lion = zoo.Animals[1].Energy > 100;
            bool elephant = zoo.Animals[2].Energy > 100;

            Assert.IsTrue(!monkey && lion && !elephant);
        }

        [TestMethod]
        public void TestFeedElephants() {
            Zoo zoo = new();
            zoo.AddAnimal(typeof(Monkey));
            zoo.AddAnimal(typeof(Lion));
            zoo.AddAnimal(typeof(Elephant));

            zoo.FeedAnimals(typeof(Elephant));

            bool monkey = zoo.Animals[0].Energy > 60;
            bool lion = zoo.Animals[1].Energy > 100;
            bool elephant = zoo.Animals[2].Energy > 100;

            Assert.IsTrue(!monkey && !lion && elephant);
        }

        [TestMethod]
        public void TestFeedAnimalsNull() {
            Zoo zoo = new();
            zoo.AddAnimal(typeof(Monkey));
            zoo.AddAnimal(typeof(Lion));
            zoo.AddAnimal(typeof(Elephant));

            zoo.FeedAnimals(null);

            bool monkey = zoo.Animals[0].Energy > 60;
            bool lion = zoo.Animals[1].Energy > 100;
            bool elephant = zoo.Animals[2].Energy > 100;

            Assert.IsTrue(!monkey && !lion && !elephant);
        }

        [TestMethod]
        public void TestFeedAnimalsInvalid() {
            Zoo zoo = new();
            zoo.AddAnimal(typeof(Monkey));
            zoo.AddAnimal(typeof(Lion));
            zoo.AddAnimal(typeof(Elephant));

            zoo.FeedAnimals(typeof(Zoo));

            bool monkey = zoo.Animals[0].Energy > 60;
            bool lion = zoo.Animals[1].Energy > 100;
            bool elephant = zoo.Animals[2].Energy > 100;

            Assert.IsTrue(!monkey && !lion && !elephant);
        }

        [TestMethod]
        public void TestFeedNoAnimals() {
            Zoo zoo = new();

            zoo.FeedAnimals(typeof(Animal));

            CollectionAssert.AreEqual(new List<Animal>(), zoo.Animals);
        }
        #endregion
    }
}
