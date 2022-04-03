using SpaProject.Models;
using SpaProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Repositories
{
    public class DepartmentsStatisticRepository : IDepartmentsStatisticRepository
    {
        private readonly ContextDb db;

        public DepartmentsStatisticRepository(ContextDb db)
        {
            this.db = db;
        }

        public async Task<int> GetSwimmingPoolStatistic()
        {
            return await Task.FromResult(db.CustomersTrack.Where(x => x.Department == EDepartments.Uszoda & x.InorOut == EInorOut.Be).GroupBy(x => x.CustomerNumber).Count());
        }
        public async Task<int> GetSaunaStatistic()
        {
            return await Task.FromResult(db.CustomersTrack.Where(x => x.Department == EDepartments.Szaunák & x.InorOut == EInorOut.Be).GroupBy(x => x.CustomerNumber).Count());
        }
        public async Task<int> GetMedicalWaterStatistic()
        {
            return await Task.FromResult(db.CustomersTrack.Where(x => x.Department == EDepartments.Gyógyvizes_medencék & x.InorOut == EInorOut.Be).GroupBy(x => x.CustomerNumber).Count());
        }
        public async Task<int> GetStrandStatistic()
        {
            return await Task.FromResult(db.CustomersTrack.Where(x => x.Department == EDepartments.Strand & x.InorOut == EInorOut.Be).GroupBy(x => x.CustomerNumber).Count());
        }
    }
}
