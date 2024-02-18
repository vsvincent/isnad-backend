namespace Domain
{
    public interface IHadithGrade
    {
        IPerson Grader { get; set; }
        HadithGradeLevels Grade { get; set; }
        string Description { get; set; }
    }
}
