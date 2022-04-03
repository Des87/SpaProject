using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Models
{
    public class VisitingTime : BaseClass
    {
        public VisitingTime(int customerNumber, TimeSpan allTime)
        {
            CustomerNumber = customerNumber;
            AllTime = allTime;
        }

        public TimeSpan AllTime { get; set; }
    }
}
