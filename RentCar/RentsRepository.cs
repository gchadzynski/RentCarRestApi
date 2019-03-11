using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar
{
    class RentsRepository : RentCarBase<Rents>, IRentsRepository
    {
        public RentsRepository(RentCarContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
