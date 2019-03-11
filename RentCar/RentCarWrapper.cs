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
        private ICarsRepository _cars;
        private IRentsRepository _rents;

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

        public ICarsRepository Cars
        {
            get
            {
                if (_cars == null)
                {
                    _cars = new CarsRepository(_repoContext);
                }

                return _cars;
            }
        }

        public IRentsRepository Rents
        {
            get
            {
                if (_rents == null)
                {
                    _rents = new RentsRepository(_repoContext);
                }

                return _rents;
            }
        }

        public RentCarWrapper(RentCarContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}
