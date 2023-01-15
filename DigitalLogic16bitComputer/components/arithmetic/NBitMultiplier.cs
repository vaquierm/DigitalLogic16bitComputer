namespace DigitalLogic16bitComputer.components.arithmetic
{
    public class NBitMultiplier
    {
        public NBitArray OutputNum { get; }

        public NBitArray FullOutputNum { get; }

        public Bit OutputOverflow { get; }

        public NBitMultiplier(NBitArray numA, NBitArray numB)
        {
            if (numA.Length != numB.Length)
            {
                throw new ArgumentException("Two numbers must have the same number of bits");
            }
            else if (numA.Length < 3)
            {
                throw new ArgumentException("Two numbers must both have at least two bits");
            }
        }
    }
}
