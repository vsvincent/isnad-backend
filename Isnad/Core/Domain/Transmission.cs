﻿namespace Domain
{
    public class Transmission : ITransmission
    {
        public Transmission(IHadith hadith, IList<IPerson> transmitter, IList<IPerson> receiver, DateOnly date) 
        { 
            Hadith = hadith;
            Transmitter = transmitter;
            Receiver = receiver;
            Date = date;
        }
        public IHadith Hadith { get; set; }
        public IList<IPerson> Transmitter { get; set; }
        public IList<IPerson> Receiver { get; set; }
        public DateOnly Date { get; set; }
    }
    
}
