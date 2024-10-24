using OpenAI.Api.Models;
using OpenAI.Chat;

namespace OpenAI.Api.Interfaces
{
    public interface IService<TEntity> where TEntity :  BaseEntity
    {
        Task<ChatCompletion> Get();
    }
}
