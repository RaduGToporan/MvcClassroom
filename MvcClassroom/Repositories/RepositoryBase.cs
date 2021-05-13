using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MvcClassroom.Models;
using Microsoft.EntityFrameworkCore;
using MvcClassroom.Data;
using MvcClassroom.Repositories;

namespace MvcClassroom.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected MvcClassroomContext MvcClassroomContext { get; set; }

        public RepositoryBase(MvcClassroomContext classroomContext)
        {
            this.MvcClassroomContext = classroomContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.MvcClassroomContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.MvcClassroomContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.MvcClassroomContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.MvcClassroomContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.MvcClassroomContext.Set<T>().Remove(entity);
        }

    }
}
