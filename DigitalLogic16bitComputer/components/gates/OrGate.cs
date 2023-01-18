namespace DigitalLogic16bitComputer.components.gates
{
    /// <summary>
    /// Represents an OR gate in a digital logic circuit.
    /// </summary>
    public class OrGate : IUpdatable
    {
        /// <summary>
        /// The first input bit for the OR gate
        /// </summary>
        internal Bit InputA { get; private set; }
        /// <summary>
        /// The second input bit for the OR gate
        /// </summary>
        internal Bit InputB { get; private set; }
        /// <summary>
        /// The output bit for the OR gate
        /// </summary>
        public Bit Output { get; private set; }

        /// <summary>
        /// Initializes a new instance of the OrGate class with two input bits
        /// </summary>
        /// <param name="inputA">The first input bit for the OR gate</param>
        /// <param name="inputB">The second input bit for the OR gate</param>
        public OrGate(Bit inputA, Bit inputB)
        {
            this.InitializeInputs(inputA, inputB);
        }

        /// <summary>
        /// Initializes a new instance of the OrGate class with N input bits
        /// </summary>
        /// <param name="inputs">The input bits for the OR gate</param>
        public OrGate(NBitArray inputs)
        {
            if (inputs.Length < 2)
            {
                throw new ArgumentException("Not enough inputs");
            }
            else if (inputs.Length == 2)
            {
                this.InitializeInputs(inputs[0], inputs[1]);
            }
            else
            {
                var firstInput = inputs.First();
                var innerGate = new OrGate(new NBitArray(inputs.TakeLast(inputs.Length - 1).ToArray()));
                this.InitializeInputs(firstInput, innerGate.Output);
            }
        }

        /// <summary>
        /// Initializes the inputs and output of the OR gate
        /// </summary>
        /// <param name="inputA">The first input</param>
        /// <param name="inputB">The second input</param>
        private void InitializeInputs(Bit inputA, Bit inputB)
        {
            this.InputA = inputA;
            this.InputB = inputB;
            this.InputA.RegisterUpdate(this);
            this.InputB.RegisterUpdate(this);
            this.Output = new Bit();
            this.Update();
        }

        /// <summary>
        /// Updates the output of the AND gate based on the inputs
        /// </summary>
        public void Update()
        {
            this.Output.Value = this.InputA.Value || this.InputB.Value;
        }

        /// <summary>
        /// Unregisters the update for the inputs
        /// </summary>
        public void Dispose()
        {
            this.InputA.UnregisterUpdate(this);
            this.InputB.UnregisterUpdate(this);
        }
    }
}
