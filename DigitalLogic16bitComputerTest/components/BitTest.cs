using DigitalLogic16bitComputer.components;


namespace DigitalLogic16bitComputerTest.components
{
    public class BitTest
    {
        [Test]
        public void BitDefaultValueCorrect()
        {
            var bit = new Bit();

            Assert.That(bit.Value, Is.EqualTo(false));

            bit = new Bit(false);

            Assert.That(bit.Value, Is.EqualTo(false));

            bit = new Bit(true);

            Assert.That(bit.Value, Is.EqualTo(true));
        }

        [Test]
        public void BitValueChanges()
        {
            var bit = new Bit();

            bit.Value = true;

            Assert.That(bit.Value, Is.EqualTo(true));

            bit.Value = false;

            Assert.That(bit.Value, Is.EqualTo(false));
        }

        class Updatable : IUpdatable
        {
            public bool updateCalled = false;
            public void Dispose()
            {
                
            }

            public void Update()
            {
                updateCalled = true;
            }
        }

        [Test]
        public void BitSendsUpdatesWhenChanges()
        {
            var bit = new Bit();
            var updateable1 = new Updatable();
            var updateable2 = new Updatable();

            bit.RegisterUpdate(updateable1);
            bit.RegisterUpdate(updateable2);

            bit.Value = true;

            Assert.That(updateable1.updateCalled , Is.EqualTo(true));
            Assert.That(updateable2.updateCalled, Is.EqualTo(true));
        }

        [Test]
        public void BitNoUpdatesWhenNoChanges()
        {
            var bit = new Bit();
            var updateable1 = new Updatable();
            var updateable2 = new Updatable();

            bit.RegisterUpdate(updateable1);
            bit.RegisterUpdate(updateable2);

            bit.Value = false;

            Assert.That(updateable1.updateCalled, Is.EqualTo(false));
            Assert.That(updateable2.updateCalled, Is.EqualTo(false));
        }

        [Test]
        public void ConnectToWorks()
        {
            var connectedBit = new Bit();
            var driverBit1 = new Bit();
            var driverBit2 = new Bit();

            connectedBit.ConnectFrom(driverBit1);
            connectedBit.ConnectFrom(driverBit2);

            Assert.That(connectedBit.Value, Is.EqualTo(false));

            driverBit1.Value = true;

            Assert.That(connectedBit.Value, Is.EqualTo(true));

            driverBit2.Value = true;

            Assert.That(connectedBit.Value, Is.EqualTo(true));

            driverBit1.Value = false;

            Assert.That(connectedBit.Value, Is.EqualTo(true));

            driverBit2.Value = false;

            Assert.That(connectedBit.Value, Is.EqualTo(false));
        }
    }
}
