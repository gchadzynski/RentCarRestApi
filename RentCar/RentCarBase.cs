using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace RentCar
{
    public abstract class RentCarBase<T> : IRentCarBase<T> where T : class
    {
        protected RentCarContext RentCarContext { get; set; }

        public RentCarBase(RentCarContext repositoryContext)
        {
            this.RentCarContext = repositoryContext;
        }

        public IEnumerable<T> FindAll()
        {
            return this.RentCarContext.Set<T>();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RentCarContext.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            this.RentCarContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.RentCarContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.RentCarContext.Set<T>().Remove(entity);
        }

        public void Save()
        {
            this.RentCarContext.SaveChanges();
        }
    }
}
