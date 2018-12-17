using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar
{
    class UserRepository : RentCarBase<User>, IUserRepository
    {
        public UserRepository(RentCarContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
