using DigitalLogic16bitComputer.components.arithmetic.shift;
using DigitalLogic16bitComputer.components;

namespace DigitalLogic16bitComputerTest.components.arithmetic.shift
{
    public class NBitShiftLeftTest
    {
        [TestCase("11001100")]
        public void ShiftN(string numToShift)
        {
            var numToShiftArray = NBitArray.BinaryStringToNBitArray(numToShift);

            var shiftAmount = NBitArray.IntToNBitArray(0, numToShift.Length);
            var nBitShift = new NBitLeftShift(numToShiftArray, shiftAmount);

            for (var i = 0; i < numToShiftArray.Length * 2; i++)
            {
                var desiredInputBits = NBitArray.IntToNBitArray(i, shiftAmount.Length);
                for (var j = 0; j < desiredInputBits.Length; j++)
                {
                    shiftAmount[j].Value = desiredInputBits[j].Value;
                }

                var breakIndex = i % numToShiftArray.Length;
                var expectedString = numToShift.Substring(breakIndex);
                for (var j = 0; j < i % numToShiftArray.Length; j++)
                {
                    expectedString += "0";
                }
                Assert.That(nBitShift.OutputNum.ToBinaryString(), Is.EqualTo(expectedString));
            }
        }
    }
}
