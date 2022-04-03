using SpaProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Repositories
{
    public class NullCheckDatabase : INullCheckDatabase
    {
        private readonly ContextDb db;

        public NullCheckDatabase(ContextDb db)
        {
            this.db = db;
        }

        public Task<bool> CheckIfEmpty()
        {
            if (!db.CustomersTrack.Any())
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
    }
}
