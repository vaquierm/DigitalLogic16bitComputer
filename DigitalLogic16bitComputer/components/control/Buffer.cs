namespace DigitalLogic16bitComputer.components.control;

/// <summary>
/// Represents a buffer circuit that connects the input to the output when the enable signal is high.
/// </summary>
public class Buffer : IUpdatable
{
    /// <summary>
    /// The output of the buffer circuit.
    /// </summary>
    public Bit Output { get; }
    /// <summary>
    /// The input to the buffer circuit.
    /// </summary>
    public Bit Input { get; }
    /// <summary>
    /// The enable signal for the buffer circuit.
    /// </summary>
    public Bit Enable { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Buffer"/> class.
    /// </summary>
    /// <param name="input">The input to the buffer circuit.</param>
    /// <param name="output">The output of the buffer circuit.</param>
    /// <param name="enable">The enable signal for the buffer circuit.</param>
    public Buffer(Bit input, Bit output, Bit enable)
    {
        this.Input = input;
        this.Output = output;
        this.Enable = enable;
        this.Enable.RegisterUpdate(this);
        this.Update();
    }

    /// <summary>
    /// Updates the buffer circuit based on the current state of the enable signal.
    /// </summary>
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

    /// <summary>
    /// Disposes of the buffer circuit by unregistering the update method from the enable signal.
    /// </summary>
    public void Dispose()
    {
        this.Enable.UnregisterUpdate(this);
    }
}
