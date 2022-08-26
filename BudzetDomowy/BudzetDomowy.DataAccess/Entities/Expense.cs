using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.Entities
{
    public class Expense : EntityBase
    {
        
        public int AccountId { get; set; }
        public int ShopId { get; set; }
        [Required]
        public float Value { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [MaxLength(30)]
        public string Recipient { get; set; }


    }
}
