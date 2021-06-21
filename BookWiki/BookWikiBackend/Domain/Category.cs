using System;
using System.Linq;
using System.Threading.Tasks;
using BookWiki.Domain.Abstractions;
using BookWiki.Domain.Models;
using BookWiki.Entity;
using BookWiki.Entity.Models;
using BookWiki.Helpers.Errors;
using BookWiki.Helpers.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BookWiki.Domain
{
    public class Category : IDomain<CategoryItem>
    {
        private BookWikiContext context { get; set; }
        private Guid userId { get; set; }
        public Category(BookWikiContext context, UserService userService) 
        {
            this.context = context;
            this.userId = userService.GetUserId();
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
                        TagName = category.CategoryName,
                        UserId = this.userId,
                        InsertedDate = DateTime.UtcNow,
                        UpdatedBy = this.userId.ToString()
                    },
                    InsertedBy = this.userId.ToString(),
                    InsertedDate = DateTime.UtcNow
                };
                this.context.Category.Add(newCategory);
                await this.context.SaveChangesAsync();
            }
            catch(DbUpdateException ex)
            {
                // overwrite error to hide db information
                throw new Exception("Error occurred");
            }
        }

        public IQueryable<CategoryItem> Get()
        {
            return (IQueryable<CategoryItem>)this.context.Category.Include(x => x.Tag).Where(x => x.Tag.UserId == this.userId).Select(x => new CategoryItem() { CategoryName = x.Tag.TagName });
        }
    }
}