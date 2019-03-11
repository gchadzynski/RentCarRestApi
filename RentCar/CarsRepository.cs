using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar
{
    class CarsRepository : RentCarBase<Cars>, ICarsRepository
    {
        public CarsRepository(RentCarContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
