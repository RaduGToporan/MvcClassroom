using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcClassroom.Data;
using MvcClassroom.Models;

namespace MvcClassroom.Repositories
{
    public class RepositoryWrapper:IRepositoryWrapper
    {
        private MvcClassroomContext classroomContext;
        private IAssignmentRepository assignmentRepository;
        private IClassRepository classRepository;

        public IAssignmentRepository AssignmentRepository
        {
            get
            {
                if(assignmentRepository==null)
                {
                    assignmentRepository = new AssignmentRepository(classroomContext);
                }
                return assignmentRepository;
            }
        }

        public void Save()
        {
            classroomContext.SaveChanges();
        }
    }
}
