namespace DigitalLogic16bitComputer.components.gates
{
    public class NotGate : IUpdatable
    {
        Bit Input { get; }
        public Bit Output { get; }

        public NotGate(Bit input)
        {
            this.Input = input;
            this.Input.RegisterUpdate(this);
            this.Output = new Bit();
            this.Update();
        }

        public void Update()
        {
            this.Output.Value = !this.Input.Value;
        }

        public void Dispose()
        {
            this.Input.UnregisterUpdate(this);
        }
    }
}
