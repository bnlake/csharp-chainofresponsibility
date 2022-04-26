namespace COR
{
    public interface IResponsibility<T>
    {
        void SetSuccessor(IResponsibility<T> successor);
        Task<T> ExecuteAsync(T payload);
    }
}