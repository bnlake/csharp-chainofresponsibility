namespace COR
{
    public static class Program
    {
        public static void Main()
        {
            ExecuteAsync().GetAwaiter().GetResult();
        }

        public static async Task<string> ExecuteAsync()
        {
            var Chain = new StringChain()
                .RegisterResponsibility(new UpperCase())
                .RegisterResponsibility(new Yell())
                .RegisterResponsibility(new Question())
                .RegisterResponsibility(new Yell())
            ;

            var result = await Chain.ExecuteAsync("testing my input");

            Console.WriteLine(result);

            return result;
        }
    }
}