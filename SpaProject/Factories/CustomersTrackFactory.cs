using SpaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Factories
{
    public class CustomersTrackFactory : ICustomersTrackFactory
    {
        public async Task<CustomersTrack> CreateObject(string lines)
        {
            string[] result = lines.Split(" ");
            EDepartments Department = (EDepartments)Enum.Parse(typeof(EDepartments), result[1]);
            EInorOut InorOut = (EInorOut)Enum.Parse(typeof(EInorOut), result[2]);
            DateTime dt = DateTime.Today.AddHours(Convert.ToInt32(result[3])).AddMinutes(Convert.ToInt32(result[4])).AddSeconds(Convert.ToInt32(result[5]));
            CustomersTrack ct = new(Guid.NewGuid(), Convert.ToInt32(result[0]), Department, InorOut, dt);
            return await Task.FromResult(ct);
        }
    }
}
