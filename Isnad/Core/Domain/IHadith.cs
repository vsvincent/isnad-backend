namespace Domain
{
    public interface IHadith
    {
        string Title { get; set; }
        string Text { get; set; }
        string Matn { get; set; }
        string Sanad { get; set; }
        IEnumerable<IHadithGrade> Grades { get; set; }
    }
}