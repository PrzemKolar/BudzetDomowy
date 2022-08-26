using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.Entities
{
    public class Earning : EntityBase
    {
        [Required]
        public float Value { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(50)]
        public string Source { get; set; }

        public int AccountId { get; set; }

    }
}
