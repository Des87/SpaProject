
namespace SpaProject.Repositories
{
    public interface IReadTxtRepository
    {
        Task<string[]> Read();
    }
}