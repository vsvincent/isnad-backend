namespace Domain
{
    public class Transmission : ITransmission
    {
        public Transmission(IHadith hadith, IPerson transmitter, DateOnly date) 
        { 
            Hadith = hadith;
            Transmitter = transmitter;
            Date = date;
        }
        public IHadith Hadith { get; set; }
        public IPerson Transmitter { get; set; }
        public DateOnly Date { get; set; }
    }
    
}
