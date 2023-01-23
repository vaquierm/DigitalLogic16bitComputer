using DigitalLogic16bitComputer.components.arithmetic.shift;
using DigitalLogic16bitComputer.components;

namespace DigitalLogic16bitComputerTest.components.arithmetic.shift
{
    public class NBitShiftTest
    {
        [TestCase("11001100")]
        [TestCase("01001100")]
        public void ShiftN(string numToShift)
        {
            var numToShiftArray = NBitArray.BinaryStringToNBitArray(numToShift);

            var shiftAmount = NBitArray.IntToNBitArray(0, numToShift.Length);
            /// false, false => LSL
            /// false, true => LSR
            /// true, false => ROR
            /// true, true => ASR
            var opSelect1 = new Bit();
            var opSelect2 = new Bit();
            var nBitShift = new NBitShift(numToShiftArray, shiftAmount, opSelect1, opSelect2);

            for (var i = 0; i < numToShiftArray.Length * 2; i++)
            {
                var desiredInputBits = NBitArray.IntToNBitArray(i, shiftAmount.Length);
                for (var j = 0; j < desiredInputBits.Length; j++)
                {
                    shiftAmount[j].Value = desiredInputBits[j].Value;
                }

                var breakIndex = i % numToShiftArray.Length;

                // LSL
                opSelect1.Value = false;
                opSelect2.Value = false;
                var expectedString = numToShift.Substring(breakIndex);
                for (var j = 0; j < i % numToShiftArray.Length; j++)
                {
                    expectedString += "0";
                }
                Assert.That(nBitShift.OutputNum.ToBinaryString(), Is.EqualTo(expectedString));

                // LSR
                opSelect1.Value = false;
                opSelect2.Value = true;
                expectedString = numToShift.Substring(0, numToShift.Length - breakIndex);
                for (var j = 0; j < i % numToShiftArray.Length; j++)
                {
                    expectedString = "0" + expectedString;
                }
                Assert.That(nBitShift.OutputNum.ToBinaryString(), Is.EqualTo(expectedString));

                // ROR
                opSelect1.Value = true;
                opSelect2.Value = false;
                expectedString = numToShift.Substring(numToShift.Length - breakIndex) + numToShift.Substring(0, numToShift.Length - breakIndex);
                Assert.That(nBitShift.OutputNum.ToBinaryString(), Is.EqualTo(expectedString));

                // ASR
                opSelect1.Value = true;
                opSelect2.Value = true;
                expectedString = numToShift.Substring(0, numToShift.Length - breakIndex);
                for (var j = 0; j < i % numToShiftArray.Length; j++)
                {
                    expectedString = numToShift[0] + expectedString;
                }
                Assert.That(nBitShift.OutputNum.ToBinaryString(), Is.EqualTo(expectedString));
            }
        }
    }
}
