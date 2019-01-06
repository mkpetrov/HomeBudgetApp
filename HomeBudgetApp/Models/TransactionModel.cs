using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetApp.Models
{
    public class TransactionModel
    {
        public DateTime Date { get; set; }

        public string Transaction { get; set; }

        public decimal Value { get; set; }

        public string TransactionType { get; set; }
    }
}
