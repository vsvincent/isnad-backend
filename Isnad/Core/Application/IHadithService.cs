using Domain;

namespace Application
{
    public interface IHadithService
    {
        Task<IHadith> GetHadithById(Guid id);
        void AddHadith(IHadith hadith);
        void UpdateHadithById(Guid id, IHadith hadith);
        void DeleteHadithById(Guid id);
    }
}