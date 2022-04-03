using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Models
{
    public abstract class BaseClass
    {
        [Required]
        public int CustomerNumber { get; set; }
    }
}
