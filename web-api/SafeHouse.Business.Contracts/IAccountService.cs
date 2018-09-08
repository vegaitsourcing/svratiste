using SafeHouse.Business.Contracts.Models;
using System;

namespace SafeHouse.Business.Contracts
{
    public interface IAccountService
    {
        Guid? GetUserIdIfCredentialsAreValid(CheckCredentialsRequest request);
    }
}
