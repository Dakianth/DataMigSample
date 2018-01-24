using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataMigSample.EF6.Models
{
    public class Sale
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public int Amount { get; set; }

        public decimal Value { get; set; }

        public decimal Dicount { get; set; }

        public Guid ProductId { get; set; }

        public Guid ClientId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Client Client { get; set; }
    }
}