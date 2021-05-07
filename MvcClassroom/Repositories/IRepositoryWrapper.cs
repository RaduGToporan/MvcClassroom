namespace MvcClassroom.Repositories
{
    public interface IRepositoryWrapper
    {
        IClassRepository ClassRepository { get; }
        IAssignmentRepository AssignmentRepository { get; }
        void Save();
    }
}