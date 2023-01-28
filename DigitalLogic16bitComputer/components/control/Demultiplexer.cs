using DigitalLogic16bitComputer.components.gates;

namespace DigitalLogic16bitComputer.components.control
{
    /// <summary>
    /// The Demultiplexer class is a digital logic gate that selects one of multiple outputs from a single input.
    /// </summary>
    public class Demultiplexer
    {
        /// <summary>
        /// The Outputs attribute holds the selected output.
        /// </summary>
        public NBitArray Outputs;

        /// <summary>
        /// The constructor for the Demultiplexer class takes in two inputs: a single input bit and an enable bit.
        /// The output will have two bits. If the input bit is false, the first bit will be true, if the input is true, the seccond bit will be true.
        /// </summary>
        /// <param name="input">The single input bit</param>
        /// <param name="enable">The enable bit</param>
        public Demultiplexer(Bit input, Bit enable)
        {
            var outputBits = new Bit[2];
            var notInput = new NotGate(input);

            outputBits[0] = new AndGate(input, enable).Output;
            outputBits[1] = new AndGate(notInput.Output, enable).Output;

            this.Outputs = new NBitArray(outputBits);
        }

        /// <summary>
        /// The constructor for the Demultiplexer.
        /// The number of output bits will equal the 2^<number of input bits>
        /// </summary>
        /// <param name="inputs">An NBitArray of input bits</param>
        /// <param name="enable">The enable bit</param>
        public Demultiplexer(NBitArray inputs, Bit enable)
        {
            if (inputs.Length == 1)
            {
                var deMux = new Demultiplexer(inputs[0], enable);
                this.Outputs = deMux.Outputs;
                return;
            }

            var msb = inputs[0];
            var notMsb = new NotGate(msb).Output;
            var restBits = inputs.SubArray(1, inputs.Length - 1);
            var msbDeMux = new Demultiplexer(restBits, new AndGate(msb, enable).Output);
            var deMuxRest = new Demultiplexer(restBits, new AndGate(notMsb, enable).Output);
            this.Outputs = new NBitArray(msbDeMux.Outputs.Concat(deMuxRest.Outputs).ToArray());
        }
    }
}
