using Domain;
using Repository;

namespace Application
{
    public class HadithService : IHadithService
    {
        IHadithRepository _hadithRepository;
        public HadithService(IHadithRepository hadithRepository)
        {
            _hadithRepository = hadithRepository;
        }
        public void AddHadith(IHadith hadith)
        {
            _hadithRepository.AddHadith(hadith);
        }

        public void DeleteHadithById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IHadith> GetHadithById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateHadithById(Guid id, IHadith hadith)
        {
            throw new NotImplementedException();
        }
    }
}