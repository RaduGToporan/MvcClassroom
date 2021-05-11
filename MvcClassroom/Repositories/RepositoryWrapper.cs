using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcClassroom.Data;
using MvcClassroom.Models;

namespace MvcClassroom.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private MvcClassroomContext _classroomContext;
        private IAssignmentRepository _assignmentRepository;
        private IClassRepository _classRepository;

        public RepositoryWrapper(MvcClassroomContext classroomContext)
        {
            _classroomContext = classroomContext;
        }

        public IClassRepository PostRepository
        {
            get
            {
                if (_classRepository == null)
                {

                    _classRepository = new ClassRepository(_classroomContext);
                }
                return _classRepository;
            }
        }

        public IAssignmentRepository AssignmentRepository
        {
            get
            {
                if (_assignmentRepository == null)
                {
                    _assignmentRepository = new AssignmentRepository(_classroomContext);
                }
                return _assignmentRepository;
            }
        }

        public IClassRepository ClassRepository => throw new NotImplementedException();

        public void Save()
        {
            _classroomContext.SaveChanges();
        }
    }
}
