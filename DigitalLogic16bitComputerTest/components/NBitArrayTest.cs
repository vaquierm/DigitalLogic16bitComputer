using DigitalLogic16bitComputer.components;

namespace DigitalLogic16bitComputerTest.components
{
    public class NBitArrayTest
    {
        [Test]
        public void CountWorks()
        {
            var bitArray = NBitArray.BinaryStringToNBitArray("0011");
            Assert.That(bitArray.Length, Is.EqualTo(4));
        }

        [Test]
        public void IndexingWorks()
        {
            var bitArrayString = "0011";
            var bitArray = NBitArray.BinaryStringToNBitArray(bitArrayString);
            for (var i = 0; i < bitArray.Length; i++)
            {
                Assert.That(bitArray[i].Value, Is.EqualTo((bitArrayString[i] == '1') ? true : false));

            }
        }

        [Test]
        public void ItteratingWorks()
        {
            var bitArrayString = "0011";
            var bitArray = NBitArray.BinaryStringToNBitArray(bitArrayString);
            var i = 0;
            foreach (var bit in bitArray)
            {
                Assert.That(bit.Value, Is.EqualTo((bitArrayString[i] == '1') ? true : false));
                i++;
            }
        }

        [TestCase(2, 8, "00000010")]
        [TestCase(6, 4, "0110")]
        public void PositiveInt(int num, int nBits, string expectedBinary)
        {
            Assert.That(NBitArray.IntToNBitArray(num, nBits).ToBinaryString(), Is.EqualTo(expectedBinary));
        }

        [TestCase(-2, 8, "11111110")]
        [TestCase(-6, 4, "1010")]
        public void NegativeInt(int num, int nBits, string expectedBinary)
        {
            Assert.That(NBitArray.IntToNBitArray(num, nBits).ToBinaryString(), Is.EqualTo(expectedBinary));
        }

        [Test]
        public void ThrowOnOutOfBounds()
        {
            Assert.DoesNotThrow(() => NBitArray.IntToNBitArray(3, 3));
            Assert.Throws(typeof(ArgumentException), () => NBitArray.IntToNBitArray(4, 3));
            Assert.Throws(typeof(ArgumentException), () => NBitArray.IntToNBitArray(5, 3));

            Assert.DoesNotThrow(() => NBitArray.IntToNBitArray(-4, 3));
            Assert.Throws(typeof(ArgumentException), () => NBitArray.IntToNBitArray(-5, 3));
            Assert.Throws(typeof(ArgumentException), () => NBitArray.IntToNBitArray(-6, 3));
        }
    }
}
