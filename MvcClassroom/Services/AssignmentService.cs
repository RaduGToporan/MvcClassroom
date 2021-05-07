using MvcClassroom.Models;
using MvcClassroom.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MvcClassroom.Services
{
    public class AssignmentService : BaseService
    {
        public AssignmentService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        {
        }

        public List<Assignment> GetAssignment()
        {
            return repositoryWrapper.AssignmentRepository.FindAll().ToList();
        }

        public List<Assignment> GetAssignmentByCondition(Expression<Func<Assignment, bool>> expression)
        {
            return repositoryWrapper.AssignmentRepository.FindByCondition(expression).ToList();
        }

        public void AddAssignment(Assignment Assignment)
        {
            repositoryWrapper.AssignmentRepository.Create(Assignment);
        }

        public void UpdateAssignment(Assignment Assignment)
        {
            repositoryWrapper.AssignmentRepository.Update(Assignment);
        }

        public void DeleteAssignment(Assignment Assignment)
        {
            repositoryWrapper.AssignmentRepository.Delete(Assignment);
        }
    }
}



