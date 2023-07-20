using HrManagement.DataAccess.Contracts;
using HrManagement.DataAccess.DataContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrManagement.DataAccess.Implementation
{
 
    public class Repository<T> : IRepositoryBase<T> where T : class,new()
    {
        private readonly HrManagementContext _context;

        public Repository(HrManagementContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public System.Linq.IQueryable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> filter = null, Func<System.Linq.IQueryable<T>, System.Linq.IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public T GetFirstorDefault(System.Linq.Expressions.Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
