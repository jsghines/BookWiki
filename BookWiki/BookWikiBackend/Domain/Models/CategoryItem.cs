using System;
using BookWiki.Helpers.Errors;

namespace BookWiki.Domain.Models
{
    public class CategoryItem
    {
        public string CategoryName { get; set; }

        public void Validate() 
        {
            if(String.IsNullOrWhiteSpace(this.CategoryName))
            {
                throw new InvalidModelException("Category Name cannot be null or empty");
            }
        }
    }
}