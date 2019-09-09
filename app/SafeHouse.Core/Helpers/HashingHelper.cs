namespace SafeHouse.Core.Helpers
{
    public class HashingHelper
    {
        public bool Verify(string text, string hash) => BCrypt.Net.BCrypt.Verify(text, hash);
    }
}
