namespace DigitalLogic16bitComputer.components.gates
{
    /// <summary>
    /// Represents a NOT gate in a digital logic circuit.
    /// </summary>
    public class NotGate : IUpdatable
    {
        /// <summary>
        /// The input bit for the NOT gate
        /// </summary>
        Bit Input { get; }
        /// <summary>
        /// The output bit for the NOT gate
        /// </summary>
        public Bit Output { get; }

        /// <summary>
        /// Initializes a new instance of the NotGate class
        /// </summary>
        /// <param name="input">The input bit for the NOT gate</param>
        public NotGate(Bit input)
        {
            this.Input = input;
            this.Input.RegisterUpdate(this);
            this.Output = new Bit();
            this.Update();
        }

        /// <summary>
        /// Updates the output bit based on the input bit
        /// </summary>
        public void Update()
        {
            this.Output.Value = !this.Input.Value;
        }

        /// <summary>
        /// Unregisters the component from the input bit
        /// </summary>
        public void Dispose()
        {
            this.Input.UnregisterUpdate(this);
        }
    }
}
