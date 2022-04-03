
namespace SpaProject.Repositories
{
    public interface IDepartmentsStatisticRepository
    {
        Task<int> GetMedicalWaterStatistic();
        Task<int> GetSaunaStatistic();
        Task<int> GetStrandStatistic();
        Task<int> GetSwimmingPoolStatistic();
    }
}