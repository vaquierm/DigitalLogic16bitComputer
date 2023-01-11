using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.registers;


namespace DigitalLogic16bitComputerTest.registers
{
    public class SRLatchTest
    {
        [Test]
        public void SRLatchTruthTable()
        {
            var inputS = new Bit(true);
            var inputR = new Bit();
            var srLatch = new SRLatch(inputS, inputR);

            Assert.That(srLatch.OutputQ.Value, Is.EqualTo(true));
            Assert.That(srLatch.OutputQPrime.Value, Is.EqualTo(false));

            inputS.Value = false;

            Assert.That(srLatch.OutputQ.Value, Is.EqualTo(true));
            Assert.That(srLatch.OutputQPrime.Value, Is.EqualTo(false));

            inputR.Value = true;

            Assert.That(srLatch.OutputQ.Value, Is.EqualTo(false));
            Assert.That(srLatch.OutputQPrime.Value, Is.EqualTo(true));

            inputR.Value = false;

            Assert.That(srLatch.OutputQ.Value, Is.EqualTo(false));
            Assert.That(srLatch.OutputQPrime.Value, Is.EqualTo(true));
        }

        [Test]
        public void SRLatchInitialValues()
        {
            var inputS = new Bit();
            var inputR = new Bit();
            var srLatch = new SRLatch(inputS, inputR);

            Assert.That(srLatch.OutputQ.Value, Is.EqualTo(false));
            Assert.That(srLatch.OutputQPrime.Value, Is.EqualTo(true));

            inputS.Value = true;
            srLatch = new SRLatch(inputS, inputR);

            Assert.That(srLatch.OutputQ.Value, Is.EqualTo(true));
            Assert.That(srLatch.OutputQPrime.Value, Is.EqualTo(false));

            inputS.Value = false;
            inputR.Value = true;

            Assert.That(srLatch.OutputQ.Value, Is.EqualTo(false));
            Assert.That(srLatch.OutputQPrime.Value, Is.EqualTo(true));
        }

        [Test]
        public void SRLatchThrowsOnInvalidState()
        {
            var inputS = new Bit(true);
            var inputR = new Bit(true);

            Assert.Throws(typeof(Exception), () => new SRLatch(inputS, inputR));

            inputS.Value = false;

            var srLatch = new SRLatch(inputS, inputR);

            Assert.Throws(typeof(Exception), () => { inputS.Value = true; });

            inputS.Value = false;
            inputR.Value = false;
            inputS.Value = true;

            srLatch = new SRLatch(inputS, inputR);

            Assert.Throws(typeof(Exception), () => { inputR.Value = true; });
        }
    }
}
