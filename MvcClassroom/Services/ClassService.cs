using MvcClassroom.Models;
using MvcClassroom.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MvcClassroom.Services
{
    public class ClassService : BaseService
    {
        public ClassService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        {
        }

        public List<Class> GetClasss()
        {
            return repositoryWrapper.ClassRepository.FindAll().ToList();
        }

        public List<Class> GetClasssByCondition(Expression<Func<Class, bool>> expression)
        {
            return repositoryWrapper.ClassRepository.FindByCondition(expression).ToList();
        }

        public void AddClass(Class Class)
        {
            repositoryWrapper.ClassRepository.Create(Class);
        }

        public void UpdateClass(Class Class)
        {
            repositoryWrapper.ClassRepository.Update(Class);
        }

        public void DeleteClass(Class Class)
        {
            repositoryWrapper.ClassRepository.Delete(Class);
        }
    }
}



