using System;
using System.Linq;
using System.Threading.Tasks;
using BookWiki.Domain.Abstractions;
using BookWiki.Domain.Models;
using BookWiki.Entity;
using BookWiki.Entity.Models;
using BookWiki.Helpers.Errors;
using Microsoft.EntityFrameworkCore;

namespace BookWiki.Domain
{
    public class Category : IDomain<CategoryItem>
    {
        public BookWikiContext context { get; set; }
        public Category(BookWikiContext context) 
        {
            this.context = context;
        }

        public async Task Add(CategoryItem category) 
        {
            try 
            {
                var newCategory = new CategoryRecord() 
                {
                    Id = System.Guid.NewGuid(),
                    Tag = new TagRecord()
                    {
                        Id = System.Guid.NewGuid(),
                        TagName = category.CategoryName
                    }
                };
                await this.context.Category.AddAsync(newCategory);
            }
            catch(DbUpdateException ex)
            {
                // overwrite error to hide db information
                throw new Exception("Error occurred");
            } 
        }
    }
}