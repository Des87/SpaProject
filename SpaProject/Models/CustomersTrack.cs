using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Models
{
    public class CustomersTrack : BaseClass
    {
        public CustomersTrack(Guid customerId, int customerNumber, EDepartments department, EInorOut inorOut, DateTime checkTime)
        {
            CustomerId = customerId;
            CustomerNumber = customerNumber;
            Department = department;
            InorOut = inorOut;
            CheckTime = checkTime;
        }

        [Key]
        public Guid CustomerId { get; set; }

        [Required]
        public EDepartments Department { get; set; }

        [Required]
        public EInorOut InorOut { get; set; }

        [Required]
        public DateTime CheckTime { get; set; }
    }
}
