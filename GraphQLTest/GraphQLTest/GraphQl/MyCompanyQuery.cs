using GraphQL.Types;
using GraphQLTest.GraphQl.Types;
using GraphQLTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTest.GraphQl
{
    public class MyCompanyQuery : ObjectGraphType
    {
        public MyCompanyQuery()
        {
            var employeesList = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name="saeed",
                    Address = new Address()
                    {
                        City = "Berlin",
                        Street = "street1"
                    }

                },
                new Employee()
                {
                    Id = 2,
                    Name="Sherif",
                    Address = new Address()
                    {
                        City = "Berlin",
                        Street = "street222"
                    }

                },
                new Employee()
                {
                    Id = 1,
                    Name="Danilo",
                    Address = new Address()
                    {
                        City = "Berlin",
                        Street = "street1234"
                    }

                },
            };
            int id = 0;

            Field<ListGraphType<EmployeeType>>("employees", resolve: context => employeesList);
            Field<EmployeeType>("employee"
                , arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" })
                , resolve: context =>
                {
                    id = context.GetArgument<int>("id");
                    return employeesList.FirstOrDefault(x => x.Id == id);

                });
            Field<ListGraphType<AddressType>>(
                name: "addresses"
                , arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" })
                , resolve: context =>
                {
                    id = context.GetArgument<int>("id");
                    return employeesList.FirstOrDefault(x => x.Id == id)?.Address;

                });
        }
    }
}
