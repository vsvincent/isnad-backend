using Domain;

namespace Application
{
    public interface IHadithService
    {
        Task<IHadith> GetHadithById(Guid id);
        void AddHadithById(Guid id);
        void UpdateHadithById(Guid id);
        void DeleteHadithById(Guid id);
    }
}