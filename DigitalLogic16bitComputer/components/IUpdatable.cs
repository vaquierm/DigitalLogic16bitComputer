namespace DigitalLogic16bitComputer.components
{
    /// <summary>
    /// Interface for updatable components
    /// </summary>
    public interface IUpdatable : IDisposable
    {
        /// <summary>
        /// Update the component's state
        /// </summary>
        void Update();
    }

}
