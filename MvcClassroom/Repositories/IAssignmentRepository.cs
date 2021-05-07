using MvcClassroom.Models;
using System;
using System.Linq.Expressions;

namespace MvcClassroom.Repositories
{
    public interface IAssignmentRepository : IRepositoryBase<Assignment>
    {
        object FindByCondition(Expression<Func<Class, bool>> expression);
    }
}
