using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Represent a single transmission of a hadith.
    /// </summary>
    public interface ITransmission
    {
        /// <summary>
        /// A reference to the hadith being transmitted.
        /// </summary>
        IHadith Hadith { get; set; }
        /// <summary>
        /// The transmitter(s) of the transmission. Usually a single person, but can be multiple.
        /// </summary>
        IList<IPerson> Transmitter { get; set; }
        /// <summary>
        /// The receiver(s) of the transmission. Usually a single person, but can be multiple.
        /// </summary>
        IList<IPerson> Receiver { get; set; }
        /// <summary>
        /// The date of the transmission.
        /// </summary>
        DateOnly Date { get; set; }
    }
}
