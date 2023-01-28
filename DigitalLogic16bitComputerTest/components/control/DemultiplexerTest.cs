using DigitalLogic16bitComputer.components.control;
using DigitalLogic16bitComputer.components;

namespace DigitalLogic16bitComputerTest.components.control
{
	public class DemultiplexerTest
	{
		[TestCase(true, true, "10")]
        [TestCase(true, false, "00")]
        [TestCase(false, true, "01")]
        [TestCase(false, false, "00")]
        public void OneBitTest(bool input, bool enable, string expected)
		{
			var deMux = new Demultiplexer(new Bit(input), new Bit(enable));
			Assert.That(deMux.Outputs.ToBinaryString(), Is.EqualTo(expected));
		}

		[Test]
		public void MultiBitTest()
		{
			var inputs = NBitArray.IntToNBitArray(0, 4);
			var enable = new Bit(true);
			var deMux = new Demultiplexer(inputs, enable);

			for (var i = 0; i < Math.Pow(2, inputs.Length); i++)
			{
				var newInputs = NBitArray.IntToNBitArray(i, 5);
				for (var j = 1; j < newInputs.Length; j++)
				{
					inputs[j - 1].Value = newInputs[j].Value;
				}

				var expectedBinary = Convert.ToString((int)Math.Pow(2, i), 2);
				var missingChars = 16 - expectedBinary.Length;
                for (var j = 0; j < missingChars; j++)
                {
                    expectedBinary = "0" + expectedBinary;
                }

                Assert.That(deMux.Outputs.ToBinaryString(), Is.EqualTo(expectedBinary));

				enable.Value = false;
                Assert.That(deMux.Outputs.ToBinaryString(), Is.EqualTo("0000000000000000"));
                enable.Value = true;
            }
        }
	}
}

