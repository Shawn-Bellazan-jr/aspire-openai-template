using OpenAI.Api.Interfaces;
using OpenAI.Api.Models;

namespace OpenAI.Api.Services
{
    public class AIService : ServiceBase<AIModel>, IAIService
    {
        public AIService(IConfiguration configuration) : base(configuration)
        {
        }


    }
}
