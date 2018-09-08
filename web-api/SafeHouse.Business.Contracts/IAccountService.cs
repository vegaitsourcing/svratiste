using SafeHouse.Business.Contracts.Models;

namespace SafeHouse.Business.Contracts
{
    public interface IAccountService
    {
        bool CheckCredentials(CheckCredentialsRequest request);
    }
}
