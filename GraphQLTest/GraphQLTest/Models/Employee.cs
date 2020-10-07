using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTest.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

    }
}
