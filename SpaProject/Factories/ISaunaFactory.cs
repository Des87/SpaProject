using SpaProject.Models;

namespace SpaProject.Factories
{
    public interface ISaunaFactory
    {
        Task<Sauna> CreateObject(int customerNumber, TimeSpan allTime);
    }
}