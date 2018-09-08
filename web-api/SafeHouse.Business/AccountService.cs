using Microsoft.EntityFrameworkCore;
using SafeHouse.Business.Contracts;
using SafeHouse.Business.Contracts.Models;
using System;

namespace SafeHouse.Business
{
    public class AccountService : IAccountService
    {
        private readonly DbContext _dbContex;

        public AccountService(DbContext context)
        {
            _dbContex = context;
        }

        public bool CheckCredentials(CheckCredentialsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
