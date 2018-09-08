namespace SafeHouse.Business.Helpers
{
    public static class HashingHelper
    {
        public static string Hash(string textToBeHashed)
            => BCrypt.Net.BCrypt.HashPassword(textToBeHashed, BCrypt.Net.BCrypt.GenerateSalt(10));

        public static bool Verify(string text, string hash)
            => BCrypt.Net.BCrypt.Verify(text, hash);
    }
}
