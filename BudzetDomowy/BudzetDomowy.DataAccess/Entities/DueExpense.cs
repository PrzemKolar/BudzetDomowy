using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.Entities
{
    public class DueExpense : EntityBase
    {
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public float Value { get; set; }
    }
}
