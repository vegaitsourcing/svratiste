namespace SafeHouse.Business.Helpers
{
    public static class HashingHelper
    {
        public static string Hash(string stringToBeCached)
            => BCrypt.Net.BCrypt.HashPassword(stringToBeCached, BCrypt.Net.BCrypt.GenerateSalt());
    }
}
