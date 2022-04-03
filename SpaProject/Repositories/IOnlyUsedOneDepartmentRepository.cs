
namespace SpaProject.Repositories
{
    public interface IOnlyUsedOneDepartmentRepository
    {
        Task<int> OnesUsed();
    }
}