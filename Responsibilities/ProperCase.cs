namespace COR
{
    public class UpperCase : BaseResponsibility<string>
    {
        public override async Task<string> ExecuteAsync(string payload)
        {
            string newPayload = payload.ToUpper();
            if (Successor is not null) return await Successor.ExecuteAsync(newPayload);
            return newPayload;
        }
    }
}