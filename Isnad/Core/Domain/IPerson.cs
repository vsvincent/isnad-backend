using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IPerson
    {
        string Name { get; set; }
        DateOnly DateOfBirth { get; set; }
    }
}
