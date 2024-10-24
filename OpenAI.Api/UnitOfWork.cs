using OpenAI.Api.Interfaces;
using OpenAI.Api.Services;

namespace OpenAI.Api
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IConfiguration configuration)
        {
            AI = new AIService(configuration);
        }
        public IAIService AI {  get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
