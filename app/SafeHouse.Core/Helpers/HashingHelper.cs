namespace SafeHouse.Core.Helpers
{
    public class HashingHelper
    {
        public string Hash(string textToBeHashed) => BCrypt.Net.BCrypt.HashPassword(textToBeHashed, BCrypt.Net.BCrypt.GenerateSalt(10));

        public bool Verify(string text, string hash) => BCrypt.Net.BCrypt.Verify(text, hash);
    }
}
