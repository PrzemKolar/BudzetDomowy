using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.Entities
{
    public class Account : EntityBase
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public float Value { get; set; }
        public bool Enabled { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<Earning> Earnings { get; set; }
    }
}
