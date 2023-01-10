namespace DigitalLogic16bitComputer.components.gates
{
    public class OrGate : IUpdatable
    {
        Bit InputA { get; }
        Bit InputB { get; }
        public Bit Output { get; }

        public OrGate(Bit inputA, Bit inputB)
        {
            this.InputA = inputA;
            this.InputB = inputB;
            this.InputA.RegisterUpdate(this);
            this.InputB.RegisterUpdate(this);
            this.Output = new Bit();
            this.Update();
        }

        public void Update()
        {
            this.Output.Value = this.InputA.Value || this.InputB.Value;
        }

        public void Dispose()
        {
            this.InputA.UnregisterUpdate(this);
            this.InputB.UnregisterUpdate(this);
        }
    }
}
