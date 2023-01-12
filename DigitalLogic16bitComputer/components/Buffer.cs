namespace DigitalLogic16bitComputer.components
{
    public class Buffer : IUpdatable
    {
        public Bit Output { get; }
        public Bit Input { get; }
        public Bit Enable { get; }
        public Buffer(Bit input, Bit output, Bit enable)
        {
            this.Input = input;
            this.Output = output;
            this.Enable = enable;
            this.Enable.RegisterUpdate(this);
            this.Update();
        }

        public void Update()
        {
            if (this.Enable.Value)
            {
                this.Output.ConnectFrom(this.Input);
            }
            else
            {
                this.Output.DisconnectFrom(this.Input);
            }
        }

        public void Dispose()
        {
            this.Enable.UnregisterUpdate(this);
        }
    }
}
