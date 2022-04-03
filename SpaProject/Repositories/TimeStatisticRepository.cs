using SpaProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Repositories
{
    public class TimeStatisticRepository : ITimeStatisticRepository
    {
        private readonly ContextDb db;

        public TimeStatisticRepository(ContextDb db)
        {
            this.db = db;
        }

        public async Task<int> Getsixtonine()
        {
            return await Task.FromResult(db.CustomersTrack.Where(x => x.InorOut == eInorOut.Ki & x.Department == 0 && x.CheckTime < DateTime.Today.AddHours(9)).Count());
        }
        public async Task<int> Getninetosixten()
        {
            return await Task.FromResult(db.CustomersTrack.Where(x => x.InorOut == eInorOut.Ki & x.Department == 0 && (x.CheckTime > DateTime.Today.AddHours(9) && x.CheckTime < DateTime.Today.AddHours(16))).Count());
        }
        public async Task<int> Getsixtentotwenty()
        {
            return await Task.FromResult(db.CustomersTrack.Where(x => x.InorOut == eInorOut.Ki & x.Department == 0 && (x.CheckTime > DateTime.Today.AddHours(16) && x.CheckTime < DateTime.Today.AddHours(20))).Count());
        }
    }
}
