namespace BlueOrigin.Tests
{
    using System;
    using NUnit.Framework;

    public class SpaceshipTests
    {
        private Spaceship spaceship;

        [SetUp]
        public void Setup()
        {
            spaceship = new Spaceship("Falcon", 100);

        }
        [Test]
        public void TestIncorectName()
        {

            Assert.Throws<ArgumentNullException>(() => new Spaceship(null, 100));
        }
        [Test]
        public void TestConstructorWorksCorectly()
        {
            Assert.AreEqual(spaceship, spaceship);
        }
        [Test]
        public void InvalidCapacityValue()
        {

            Assert.Throws<ArgumentException>(() => new Spaceship("Falcon",-10));

        }
        [Test]
        public void AddingAstrWorks()
        {
            Astronaut astronaut = new Astronaut("fin", 100);
            spaceship.Add(astronaut);

            Assert.AreEqual(1, spaceship.Count);
        }
        [Test]
        public void AddingWhenFull()
        {
            spaceship = new Spaceship("Falc",1);

            Astronaut astronaut = new Astronaut("fin", 100);
            Astronaut astronaut1 = new Astronaut("min", 102);
            spaceship.Add(astronaut);

            Assert.Throws<InvalidOperationException>(() => spaceship.Add(astronaut1));
        }
        [Test]
        public void AddingAlreadyAddedAstronaut()
        {

            Astronaut astronaut = new Astronaut("fin", 100);
            spaceship.Add(astronaut);

            Assert.Throws<InvalidOperationException>(()=>spaceship.Add(astronaut));
        }
        [Test]
        public void RemoveWorksCorrectly()
        {
            Astronaut astronaut = new Astronaut("fin", 100);
            spaceship.Add(astronaut);
             spaceship.Remove(astronaut.Name);


            Assert.AreEqual(0, spaceship.Count);

        }

       
    }
}