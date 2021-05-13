using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MvcClassroom.Data;
using MvcClassroom.Models;
namespace MvcClassroom.Repositories
{
    public class AssignmentRepository:RepositoryBase<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(MvcClassroomContext classroomContext)
            : base(classroomContext)
        {
        }

        public Assignment FindByCondition(Expression<Func<Class, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
