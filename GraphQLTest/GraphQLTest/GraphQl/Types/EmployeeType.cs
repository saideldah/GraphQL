using GraphQL.Types;
using GraphQLTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTest.GraphQl.Types
{
    public class EmployeeType : ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Name = "Employee";
            Field(t => t.Id);
            Field(t => t.Name);
        }
    }
}
