using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.DataAccess.Entities
{
    public class ConstantExpense :EntityBase
    {
        public float Value { get; set; }

        public int ShopId { get; set; }
    }
}
