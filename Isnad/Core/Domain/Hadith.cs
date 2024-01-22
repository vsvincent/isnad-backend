using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Hadith : IHadith
    {
        public Hadith(string title, string text, string matn, string sanad, IEnumerable<IHadithGrade> grades) 
        {
            Title = title;
            Text = text;
            Matn = matn;
            Sanad = sanad;
            Grades = grades;
        }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Matn { get; set; }
        public string Sanad { get; set; }
        public IEnumerable<IHadithGrade> Grades { get; set; }
    }
}
