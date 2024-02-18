namespace Domain
{
    public interface IPerson
    {
        string Name { get; set; }
        DateOnly DateOfBirth { get; set; }
    }
}
