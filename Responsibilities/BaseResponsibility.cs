namespace COR
{
    public abstract class BaseResponsibility<T> : IResponsibility<T>
    {
        protected IResponsibility<T>? Successor;

        public BaseResponsibility() { }

        public abstract Task<T> ExecuteAsync(T payload);

        public void SetSuccessor(IResponsibility<T> successor)
        {
            this.Successor = successor;
        }
    }
}