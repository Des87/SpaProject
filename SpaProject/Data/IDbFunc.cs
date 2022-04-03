
namespace SpaProject.Data
{
    public interface IDbFunc
    {
        Task AddItem(object model);
        Task SaveToDatabase();
    }
}