using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.Entities
{
    public class Shop : EntityBase
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Logo { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<ConstantExpense> ConstantExpenses { get; set; }
    }
}
