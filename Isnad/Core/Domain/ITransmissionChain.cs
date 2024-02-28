namespace Domain
{
    /// <summary>
    /// Represent an entire chain of transmission of a hadith
    /// </summary>
    public interface ITransmissionChain
    {
        /// <summary>
        /// A list of transmissions in the chain with index indicating the order of transmission
        /// </summary>
        LinkedList<ITransmission> Transmissions { get; set; }
    }
}
