namespace DigitalLogic16bitComputer.components.control
{
    public class NBitMultiplexer
    {
        public NBitArray NBitOutput { get; }
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
    }
}
