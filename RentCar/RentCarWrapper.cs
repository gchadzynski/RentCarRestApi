using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar
{
    public class RentCarWrapper: IRentCarWrapper
    {
        private RentCarContext _repoContext;
        private IUserRepository _owner;

        public IUserRepository User
        {
            get
            {
                if (_owner == null)
                {
                    _owner = new UserRepository(_repoContext);
                }

                return _owner;
            }
        }

        public RentCarWrapper(RentCarContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}
