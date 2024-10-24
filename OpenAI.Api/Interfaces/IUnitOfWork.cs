namespace OpenAI.Api.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IAIService AI {  get; }
    }
}
