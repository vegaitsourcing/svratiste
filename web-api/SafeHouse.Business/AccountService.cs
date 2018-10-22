using System;
using System.Linq;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using SafeHouse.Business.Helpers;
using SafeHouse.Data;
using SafeHouse.Data.Entities;

namespace SafeHouse.Business
{
    public class AccountService : IAccountService
    {
        private readonly SafeHouseDbContext _dbContext;
        private readonly HashingHelper _hashingHelper;

        public AccountService(SafeHouseDbContext context, HashingHelper hashingHelper)
        {
            _dbContext = context;
            _hashingHelper = hashingHelper;
        }

        public Guid? GetUserIdIfCredentialsAreValid(CheckCredentialsRequest request)
        {
            var user = _dbContext.SafeHouseUsers.FirstOrDefault(u => u.Username == request.Username);

            return user == null ? null : (CheckIfPasswordIsCorrect(user.Password, request.Password) ? user.Id : (Guid?)null);
        }

        private bool CheckIfPasswordIsCorrect(string userPassword, string enteredPassword) => _hashingHelper.Verify(enteredPassword, userPassword);
    }
}
