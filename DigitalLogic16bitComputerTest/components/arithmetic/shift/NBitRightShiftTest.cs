using DigitalLogic16bitComputer.components.arithmetic.shift;
using DigitalLogic16bitComputer.components;

namespace DigitalLogic16bitComputerTest.components.arithmetic.shift
{
	public class NBitRightShiftTest
	{
		[TestCase("11001100")]
		public void ShiftN(string numToShift)
		{
			var numToShiftArray = NBitArray.BinaryStringToNBitArray(numToShift);

			var shiftAmount = NBitArray.IntToNBitArray(0, numToShift.Length);

			var shiftedOutBitsToShiftedInBitsDelegate = delegate (NBitArray shiftedOutBits, Bit msb) { return shiftedOutBits; };
            var nBitShift = new NBitRightShift(numToShiftArray, shiftAmount, shiftedOutBitsToShiftedInBitsDelegate);

			for (var i = 0; i < numToShiftArray.Length * 2; i++)
			{
                var desiredInputBits = NBitArray.IntToNBitArray(i, shiftAmount.Length);
                for (var j = 0; j < desiredInputBits.Length; j++)
                {
                    shiftAmount[j].Value = desiredInputBits[j].Value;
                }

				var breakIndex = numToShiftArray.Length - i % numToShiftArray.Length;
				var expectedString = numToShift.Substring(breakIndex) + numToShift.Substring(0, breakIndex);
                Assert.That(nBitShift.OutputNum.ToBinaryString(), Is.EqualTo(expectedString));
            }
        }
	}
}
