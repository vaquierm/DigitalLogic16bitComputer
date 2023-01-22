namespace DigitalLogic16bitComputer.components.control
{
    /// <summary>
    /// Represents a multiplexer that selects one of multiple N-bit inputs based on a selection bit or N-bit select signal.
    /// </summary>
    public class NBitMultiplexer
    {
        /// <summary>
        /// The output of the multiplexer, an N-bit array.
        /// </summary>
        public NBitArray NBitOutput { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NBitMultiplexer"/> class that selects between two N-bit inputs based on a selection bit.
        /// </summary>
        /// <param name="nBitInputA">The first N-bit input to be selected.</param>
        /// <param name="nBitInputB">The second N-bit input to be selected.</param>
        /// <param name="select">The selection bit, where a value of 1 selects <paramref name="nBitInputA"/> and a value of 0 selects <paramref name="nBitInputB"/>.</param>
        /// <exception cref="ArgumentException">Inputs must have the same length</exception>
        public NBitMultiplexer(NBitArray nBitInputA, NBitArray nBitInputB, Bit select)
        {
            if (nBitInputA.Length != nBitInputB.Length)
            {
                throw new ArgumentException("Inputs must have the same length");
            }
            var outputBits = new Bit[nBitInputA.Length];
            for (int i = 0; i < nBitInputA.Length; i++)
            {
                var mux = new Multiplexer(nBitInputA[i], nBitInputB[i], select);
                outputBits[i] = mux.Output;
            }
            this.NBitOutput = new NBitArray(outputBits);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NBitMultiplexer"/> class that selects between multiple N-bit inputs based on an N-bit select signal.
        /// </summary>
        /// <param name="inputArrays">The array of N-bit inputs to be selected from.</param>
        /// <param name="selectBits">The N-bit selection</param>
        public NBitMultiplexer(NBitArray[] inputArrays, NBitArray selectBits)
        {
            if (inputArrays.Length == 0)
            {
                throw new ArgumentException("Input arrays cannot be empty");
            }
            var outputBits = new Bit[inputArrays[0].Length];

            for (var i = 0; i < outputBits.Length; i++)
            {
                var inputs = new NBitArray(inputArrays.Select(input => input[i]).ToArray());
                outputBits[i] = new Multiplexer(inputs, selectBits).Output;
            }
            this.NBitOutput = new NBitArray(outputBits);
        }
    }
}
