
namespace SpaProject.Repositories
{
    public interface INullCheckDatabase
    {
        Task<bool> CheckIfEmpty();
    }
}