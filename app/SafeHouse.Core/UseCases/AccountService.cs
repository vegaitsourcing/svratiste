using System;
using System.Linq;
using SafeHouse.Core.Abstractions;
using SafeHouse.Core.Abstractions.Persistence;
using SafeHouse.Core.Entities;
using SafeHouse.Core.Helpers;
using SafeHouse.Core.Models;

namespace SafeHouse.Core.UseCases
{
    public class AccountService : IAccountService
    {
        private readonly HashingHelper _hashingHelper;
        private readonly IRepository<SafeHouseUser> _userRepository;

        public AccountService(IRepository<SafeHouseUser> userRepository, HashingHelper hashingHelper)
        {
            _userRepository = userRepository;
            _hashingHelper = hashingHelper;
        }

        public Guid? GetUserIdForCredentials(CheckCredentialsRequest request)
        {
            if(request.Username == "safehouse" && request.Password == "S@feH0use20!8")
            {
                return _userRepository.GetBy(user => user.Username == request.Username)
                    .Where(user => IsValid(request.Password, user.Password))
                    .DefaultIfEmpty(new SafeHouseUser())
                    .First()
                    .Id;
            } else
            {
                return null;
            }
        }

        private bool IsValid(string password, string hashedPassword)
        {
            return _hashingHelper.Verify(password, hashedPassword);
        }
    }
}