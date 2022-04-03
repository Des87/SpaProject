using SpaProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Repositories
{
    public class OnlyUsedOneDepartmentRepository : IOnlyUsedOneDepartmentRepository
    {
        private readonly ContextDb db;

        public OnlyUsedOneDepartmentRepository(ContextDb db)
        {
            this.db = db;
        }

        public async Task<int> OnesUsed()
        {
             return await Task.FromResult(db.CustomersTrack.GroupBy(x => x.CustomerNumber).Where(x => x.Count() == 4).Select(y => y.Key).Count());
        }
    }
}
