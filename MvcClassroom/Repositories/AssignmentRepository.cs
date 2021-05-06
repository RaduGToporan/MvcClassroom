using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcClassroom.Data;
using MvcClassroom.Models;
namespace MvcClassroom.Repositories
{
    public class AssignmentRepository:RepositoryBase<Assignment>
    {
        public AssignmentRepository(MvcClassroomContext classroomContext)
            : base(classroomContext)
        {
        }
    }
}
