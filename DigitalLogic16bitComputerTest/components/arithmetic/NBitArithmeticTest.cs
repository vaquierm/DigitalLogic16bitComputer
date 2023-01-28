using DigitalLogic16bitComputer.components.arithmetic;
using DigitalLogic16bitComputer.components;

namespace DigitalLogic16bitComputerTest.components.arithmetic
{
	public class NBitArithmeticTest
	{
		[TestCase(13, 4, 8)]
        [TestCase(1, -9, 16)]
        [TestCase(-58, 4871, 32)]
        public void Runs(int numA, int numB, int numBits)
		{
            var numABits = NBitArray.IntToNBitArray(numA, numBits);
            var numBBits = NBitArray.IntToNBitArray(numB, numBits);
			var opSelectBits = new Bit[] { new Bit(), new Bit(), new Bit(), new Bit() };
			var opSelect = new NBitArray(opSelectBits);
			var nBitArithmetic = new NBitArithmetic(numABits, numBBits, opSelect[0], opSelect[1], opSelect[2], opSelect[3]);

            Assert.That(nBitArithmetic.OutputNum.ToInt(), Is.EqualTo(numA + numB));

			opSelect[3].Value = true;

            Assert.That(nBitArithmetic.OutputNum.ToInt(), Is.EqualTo(numA - numB));

			opSelect[2].Value = true;
            opSelect[3].Value = false;

            Assert.That(nBitArithmetic.OutputNum.ToInt(), Is.EqualTo(numA / numB));

			opSelect[3].Value = true;

            Assert.That(nBitArithmetic.OutputNum.ToInt(), Is.EqualTo(numA % numB));

            opSelect[1].Value = true;
            opSelect[2].Value = false;
            opSelect[3].Value = false;

            Assert.That(nBitArithmetic.OutputNum.ToInt(), Is.EqualTo(numA * numB));

            opSelect[3].Value = true;

            Assert.That(nBitArithmetic.OutputNum.ToBinaryString(), Is.EqualTo(makeNBit(Convert.ToString(~numA, 2), numBits)));

            opSelect[2].Value = true;
            opSelect[3].Value = false;

            Assert.That(nBitArithmetic.OutputNum.ToBinaryString(), Is.EqualTo(makeNBit(Convert.ToString(numA & numB, 2), numBits)));

            opSelect[3].Value = true;

            Assert.That(nBitArithmetic.OutputNum.ToBinaryString(), Is.EqualTo(makeNBit(Convert.ToString(numA | numB, 2), numBits)));

            opSelect[0].Value = true;
            opSelect[1].Value = false;
            opSelect[2].Value = false;
            opSelect[3].Value = false;

            Assert.That(nBitArithmetic.OutputNum.ToBinaryString(), Is.EqualTo(makeNBit(Convert.ToString(numA ^ numB, 2), numBits)));

            opSelect[3].Value = true;

            Assert.That(nBitArithmetic.OutputNum.ToBinaryString(), Is.EqualTo(makeNBit(Convert.ToString(~(numA | numB), 2), numBits)));

            opSelect[2].Value = true;
            opSelect[3].Value = false;

            Assert.That(nBitArithmetic.OutputNum.ToBinaryString(), Is.EqualTo(makeNBit(Convert.ToString(~(numA & numB), 2), numBits)));

            opSelect[3].Value = true;

            Assert.That(nBitArithmetic.OutputNum.ToInt(), Is.EqualTo(-numA));

            opSelect[1].Value = true;
            opSelect[2].Value = false;
            opSelect[3].Value = false;

            Assert.That(nBitArithmetic.OutputNum.ToBinaryString(), Is.EqualTo(makeNBit(Convert.ToString(numA << numB, 2), numBits)));

            opSelect[3].Value = true;

            Assert.That(nBitArithmetic.OutputNum.ToBinaryString(), Is.EqualTo(makeNBit(Convert.ToString(numA >> numB, 2), numBits)));

            opSelect[2].Value = true;
            opSelect[3].Value = false;

            var breakIndex = numB % numBits;
            var numToShift = makeNBit(Convert.ToString(numA, 2), numBits);
            var expectedString = numToShift.Substring(numBits - breakIndex) + numToShift.Substring(0, numBits - breakIndex);

            Assert.That(nBitArithmetic.OutputNum.ToBinaryString(), Is.EqualTo(expectedString));

            opSelect[3].Value = true;

            expectedString = numToShift.Substring(0, numToShift.Length - breakIndex);
            for (var j = 0; j < breakIndex; j++)
            {
                expectedString = numToShift[0] + expectedString;
            }

            Assert.That(nBitArithmetic.OutputNum.ToBinaryString(), Is.EqualTo(expectedString));

        }

        public static string makeNBit(string binaryString, int NBits)
        {
            if (binaryString.Length > NBits)
            {
                return binaryString.Substring(binaryString.Length - NBits);
            }
            var toAdd = NBits - binaryString.Length;
            for (var i = 0; i < toAdd; i++)
            {
                binaryString = "0" + binaryString;
            }
            return binaryString;
        }
    }
}

