using SpaProject.Models;

namespace SpaProject.Repositories
{
    public interface ILongestTimeInTheSpaRepository
    {
        Task<VisitingTime> LongestTime();
    }
}