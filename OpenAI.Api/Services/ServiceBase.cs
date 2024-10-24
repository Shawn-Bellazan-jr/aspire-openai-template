using OpenAI.Api.Interfaces;
using OpenAI.Api.Models;
using OpenAI.Chat;

namespace OpenAI.Api.Services
{
    public abstract class ServiceBase<T>: IService<T> where T : BaseEntity
    {
        private readonly ChatClient _client;
        private readonly string _apiKey = "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";
        protected ServiceBase(IConfiguration configuration)
        {
            _client = new("gpt-4o-mini", _apiKey);
        }


        public async Task<ChatCompletion> Get()
        {
            return await _client.CompleteChatAsync("Hello");
        }
    }
}
