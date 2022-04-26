using System.Text;

namespace COR
{
    public class Yell : BaseResponsibility<string>
    {
        public override async Task<string> ExecuteAsync(string payload)
        {
            StringBuilder sb = new StringBuilder(payload);
            string newPayload = sb.Append('!').ToString();
            if (Successor is not null) return await Successor.ExecuteAsync(newPayload);
            return newPayload;
        }
    }
}