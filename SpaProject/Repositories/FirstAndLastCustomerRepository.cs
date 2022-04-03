using SpaProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Repositories
{
    public class FirstAndLastCustomerRepository : IFirstAndLastCustomerRepository
    {
        private readonly ContextDb db;

        public FirstAndLastCustomerRepository(ContextDb db)
        {
            this.db = db;
        }

        public async Task<DateTime> FirstCustomer()
        {
            return await Task.FromResult(db.CustomersTrack.Where(x => x.InorOut == EInorOut.Ki & x.Department == 0).OrderBy(y => y.CheckTime).First().CheckTime);

        }
        public async Task<DateTime> LastCustomer()
        {
            return await Task.FromResult(db.CustomersTrack.Where(x => x.InorOut == EInorOut.Ki & x.Department == 0).OrderBy(y => y.CheckTime).Last().CheckTime);
        }
    }
}
