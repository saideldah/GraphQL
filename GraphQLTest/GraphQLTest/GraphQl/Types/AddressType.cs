using GraphQL.Types;
using GraphQLTest.Models;

namespace GraphQLTest.GraphQl.Types
{
    public class AddressType : ObjectGraphType<Address>
    {
        public AddressType()
        {
            Name = "Address";
            Field(t => t.City);
            Field(t => t.Street);
        }
    }
}
