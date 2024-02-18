using Domain;

namespace Repository
{
    public interface IHadithRepository
    {
        Task<IHadith> GetHadithById(Guid id);
        Task AddHadith(IHadith hadith);
        void UpdateHadithById(Guid id, IHadith hadith);
        void DeleteHadithById(Guid id);
    }
}
