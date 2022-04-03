using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Models
{
    public class Sauna :BaseClass
    {
        public Sauna(Guid saunaId, int customerNumber, TimeSpan allTime)
        {
            SaunaId = saunaId;
            CustomerNumber = customerNumber;
            AllTime = allTime;
        }

        [Key]
        public Guid SaunaId { get; set; }

        [Required]
        public TimeSpan AllTime { get; set; }
    }
}
