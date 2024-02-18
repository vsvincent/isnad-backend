namespace Domain
{
    public class HadithGrade : IHadithGrade
    {
        public HadithGrade(IPerson grader, HadithGradeLevels grade)
        {
            Grader = grader;
            Grade = grade;
        }
        public IPerson Grader { get; set; }
        public HadithGradeLevels Grade { get; set; }
        public string Description { get; set; } = String.Empty;
    }
}
