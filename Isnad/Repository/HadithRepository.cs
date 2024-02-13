using Domain;
using Neo4j.Driver;

namespace Repository
{
    public class HadithRepository : IHadithRepository
    {
        private readonly Neo4jDatabaseManager _dbManager = new Neo4jDatabaseManager("", "", "");

        public HadithRepository()
        {
        }

        public async Task AddHadith(IHadith hadith)
        {
            try
            {
                using (IAsyncSession session = _dbManager.GetSession())
                {
                    await session.ExecuteWriteAsync(async tx =>
                    {
                        await tx.RunAsync(
                            "CREATE (h:Hadith {title: $title, text: $text, matn: $matn, sanad: $sanad})",
                            new { title = hadith.Title, text = hadith.Text, matn =  hadith.Matn, sanad = hadith.Sanad });
                    });
                }
            }
            catch (ClientException ex)
            {
                Console.WriteLine($"Neo4j ClientException: {ex.Message}");
                throw;
            }
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
