using SpaProject.Models;

namespace SpaProject.Repositories
{
    public interface ISaunaListRepository
    {
        Task<List<VisitingTime>> GetVisitedTime();
    }
}