using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudzetDomowy.ApplicationServices.API.Domain.Models
{
    public class Account
    {
        public string Name { get; set; }
        public float Value { get; set; }
        public bool Enabled { get; set; }
    }
}
