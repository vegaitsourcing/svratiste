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
        private readonly IRepository<SafeHouseUser> _userRepository;
        private readonly HashingHelper _hashingHelper;

        public AccountService(IRepository<SafeHouseUser> userRepository, HashingHelper hashingHelper)
        {
            _userRepository = userRepository;
            _hashingHelper = hashingHelper;
        }

        public Guid? GetUserIdForCredentials(CheckCredentialsRequest request)
            => _userRepository.GetBy(shu => shu.Username == request.Username)
                .Where(shu => CheckIfPasswordIsCorrect(shu.Password, request.Password))
                .DefaultIfEmpty(new SafeHouseUser())
                .First()
                .Id;

        private bool CheckIfPasswordIsCorrect(string userPassword, string enteredPassword)
            => _hashingHelper.Verify(enteredPassword, userPassword);
    }
}