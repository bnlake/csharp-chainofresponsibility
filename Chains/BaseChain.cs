namespace COR
{
    public abstract class BaseChain<T> : IChain<T>
    {
        protected readonly IList<IResponsibility<T>> Responsibilities;

        public BaseChain()
        {
            Responsibilities = new List<IResponsibility<T>>();
        }

        private bool HasNoResponsibilities() => !Responsibilities.Any();

        public Task<T> ExecuteAsync(T action)
        {
            if (HasNoResponsibilities()) return Task.FromResult<T>(action);
            return Responsibilities.First().ExecuteAsync(action);
        }

        public IChain<T> RegisterResponsibility(IResponsibility<T> responsibility)
        {
            if (this.HasNoResponsibilities()) this.Responsibilities.Add(responsibility);
            else
            {
                this.Responsibilities.Last().SetSuccessor(responsibility);
                this.Responsibilities.Add(responsibility);
            }

            return this;
        }
    }
}