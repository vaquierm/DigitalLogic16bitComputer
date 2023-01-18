namespace DigitalLogic16bitComputer.components
{
    /// <summary>
    /// Represents a single bit in a digital logic circuit.
    /// </summary>
    public class Bit : IUpdatable
    {
        private readonly List<IUpdatable> comonentsToUpdate;
        private readonly List<Bit> connections;

        private bool internalValue;
        /// <summary>
        /// Gets or sets the value of the bit (either true or false)
        /// </summary>
        public bool Value
        {
            get
            {
                return internalValue;
            }
            set
            {
                if (internalValue == value)
                {
                    return;
                }
                internalValue = value;

                // Update all components dependent on this bit
                this.comonentsToUpdate.ForEach(component => component.Update());
            }
        }
        /// <summary>
        /// Initializes a new instance of the Bit class with an optional initial value
        /// </summary>
        /// <param name="value">The initial value of the bit (default is false)</param>
        public Bit(bool value = false)
        {
            this.internalValue = value;
            this.comonentsToUpdate = new List<IUpdatable>();
            this.connections = new List<Bit>();
        }

        /// <summary>
        /// Registers a component to be updated when the value of this bit changes
        /// </summary>
        /// <param name="component">The component to be updated</param>
        public void RegisterUpdate(IUpdatable component)
        {
            this.comonentsToUpdate.Add(component);
        }

        /// <summary>
        /// Unregisters a component from being updated when the value of this bit changes
        /// </summary>
        /// <param name="component">The component to be removed</param>
        public void UnregisterUpdate(IUpdatable component)
        {
            this.comonentsToUpdate.Remove(component);
        }

        /// <summary>
        /// Connects this bit to another bit
        /// </summary>
        /// <param name="bit">The bit to be connected to</param>
        public void ConnectFrom(Bit bit)
        {
            this.connections.Add(bit);
            bit.RegisterUpdate(this);
            this.Update();
        }

        /// <summary>
        /// Disconnects this bit from another bit
        /// </summary>
        /// <param name="bit">The bit to be disconnected from</param>
        public void DisconnectFrom(Bit bit)
        {
            this.connections.Remove(bit);
                bit.UnregisterUpdate(this);
                this.Update();
        }

        /// <summary>
        /// Updates the value of this bit based on its connections
        /// </summary>
        public void Update()
        {
            this.Value = this.connections.Any(bit => bit.Value);
        }

        /// <summary>
        /// Disposes of this bit and its connections
        /// </summary>
        public void Dispose()
        {
            this.connections.ForEach(bit => bit.UnregisterUpdate(this));
        }

        /// <summary>
        /// Converts the value of this bit to a string representation
        /// </summary>
        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
