using SpaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Factories
{
    public class SaunaFactory : ISaunaFactory
    {
        public async Task<Sauna> CreateObject(int customerNumber, TimeSpan allTime)
        {
            Sauna s = new(Guid.NewGuid(), customerNumber, allTime);
            return await Task.FromResult(s);
        }
    }
}
