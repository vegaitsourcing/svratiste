using System;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.Abstractions
{
    public interface IAccountService
    {
        Guid? GetUserIdForCredentials(CheckCredentialsRequest request);
    }
}
