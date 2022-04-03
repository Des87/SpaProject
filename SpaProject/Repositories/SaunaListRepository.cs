using SpaProject.Data;
using SpaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Repositories
{
    public class SaunaListRepository : ISaunaListRepository
    {
        private readonly ContextDb db;

        public SaunaListRepository(ContextDb db)
        {
            this.db = db;
        }

        public async Task<List<VisitingTime>> GetVisitedTime()
        {
            var t = db.CustomersTrack.Where(x => x.Department == EDepartments.Szaunák).OrderBy(x => x.CustomerNumber).ThenBy(x => x.CheckTime).ToList();
            List<VisitingTime> vt = new();

            for (int i = 0; i < t.Count; i += 2)
            {
                var max = t[i + 1].CheckTime - t[i].CheckTime;
                vt.Add(new VisitingTime(t[i].CustomerNumber, max));
            }
            return await Task.FromResult(vt);
        }
    }
}
