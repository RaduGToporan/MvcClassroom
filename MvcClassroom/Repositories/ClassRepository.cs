using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcClassroom.Data;
using MvcClassroom.Models;
namespace MvcClassroom.Repositories
{
    public class ClassRepository : RepositoryBase<Class>
    {
        public ClassRepository(MvcClassroomContext classroomContext)
            : base(classroomContext)
        {
        }
    }
}