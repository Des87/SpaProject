using SpaProject.Models;

namespace SpaProject.Factories
{
    public interface ICustomersTrackFactory
    {
        Task<CustomersTrack> CreateObject(string lines);
    }
}