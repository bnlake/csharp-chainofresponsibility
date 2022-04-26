namespace COR
{
    public interface IChain<T>
    {
        Task<T> ExecuteAsync(T action);
        IChain<T> RegisterResponsibility(IResponsibility<T> responsbility);
    }
}