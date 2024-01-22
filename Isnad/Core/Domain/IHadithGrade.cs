using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IHadithGrade
    {
        IPerson Grader { get; set; }
        HadithGradeLevels Grade { get; set; }
        string Description { get; set; }
    }
}
