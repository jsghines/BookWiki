using System;
using HotChocolate;

namespace BookWiki.GraphQL.Filters 
{
    public class GraphQLErrorFilter : IErrorFilter
    {
        public IError OnError(IError error)
        {
            return error.WithMessage(error.Exception.Message);
        }
    }
}