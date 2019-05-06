using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace SafeHouse.Web.Helpers
{
    public static class JwtSecurityKey
    {
        public static SymmetricSecurityKey Create(string secret) => new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));
    }
}
