using System;

namespace DataMigSample.EF6.Models
{
    public class Client
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public int Code { get; set; }

        public Client()
        {
        }

        public Client(string name, int code)
        {
            Name = name;
            Code = code;
        }
    }
}