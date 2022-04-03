using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Data
{
    public class DbFunc : IDbFunc
    {
        private readonly ContextDb db;

        public DbFunc(ContextDb db)
        {
            this.db = db;
        }

        public async Task AddItem(object model)
        {
            await db.AddAsync(model);
        }
        public async Task SaveToDatabase()
        {
            await db.SaveChangesAsync();
        }
    }
}
