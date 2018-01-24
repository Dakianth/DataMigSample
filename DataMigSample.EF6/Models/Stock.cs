using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataMigSample.EF6.Models
{
    public class Stock
    {
        public Guid Id { get; set; }

        public int Amount { get; set; }

        public DateTime Date { get; set; }

        public decimal UnitValue { get; set; }

        public Guid ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}