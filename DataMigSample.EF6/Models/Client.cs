using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataMigSample.EF6.Models
{
    public class Client
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Code { get; set; }
    }
}