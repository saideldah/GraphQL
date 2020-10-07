using GraphQL;
using GraphQL.Types;
using System;

namespace GraphQLTest.GraphQl
{
    public class MyCompanySchema : Schema, ISchema
    {
        public MyCompanySchema(IDependencyResolver dependencyResolver) : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<MyCompanyQuery>();
        }
    }
}
