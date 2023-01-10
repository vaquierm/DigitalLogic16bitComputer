using System;
namespace DigitalLogic16bitComputer.components
{
    public class Bit : IUpdatable
    {
        private readonly List<IUpdatable> comonentsToUpdate;
        private readonly List<Bit> connections;

        private bool internalValue;
        public bool Value
        {
            get
            {
                return internalValue;
            }
            set
            {
                if (internalValue == value) {
                    return;
                }
                internalValue = value;

                // Update all components dependent on this bit
                this.comonentsToUpdate.ForEach(component => component.Update());
            }
        }
        public Bit(bool value = false)
        {
            this.internalValue = value;
            this.comonentsToUpdate = new List<IUpdatable>();
            this.connections = new List<Bit>();
        }

        public void RegisterUpdate(IUpdatable component)
        {
            this.comonentsToUpdate.Add(component);
        }

        public void UnregisterUpdate(IUpdatable component)
        {
            this.comonentsToUpdate.Remove(component);
        }

        public void ConnectFrom(Bit bit)
        {
            this.connections.Add(bit);
            bit.RegisterUpdate(this);
            this.Update();
        }

        public void DisconnectFrom(Bit bit)
        {
            this.connections.Remove(bit);
            bit.UnregisterUpdate(this);
        }

        public void Update()
        {
            this.Value = this.connections.Any(bit => bit.Value);
        }

        public void Dispose()
        {
            this.connections.ForEach(bit => bit.UnregisterUpdate(this));
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
