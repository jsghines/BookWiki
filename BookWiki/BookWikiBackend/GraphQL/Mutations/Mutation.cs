using System;
using System.Threading.Tasks;
using BookWiki.Domain;
using BookWiki.Domain.Models;
using BookWiki.Entity;
using BookWiki.Entity.Models;
using HotChocolate;
using HotChocolate.Types;

namespace BookWiki.GraphQL.Queries.Mutations
{
    public class Mutation
    {
        public async Task<CategoryItem> CategoryItem ([Service] Category category, string categoryName)     
        {
            var categoryItem = new CategoryItem
            { 
                CategoryName = categoryName
            };
            categoryItem.Validate();
            await category.Add(categoryItem);
            return categoryItem;
        }
    }
}