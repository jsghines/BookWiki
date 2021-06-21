using System;
using BookWiki.Helpers.Constants;
using BookWiki.Helpers.Errors;

namespace BookWiki.Domain.Models
{
    public class CategoryItem
    {
        public string CategoryName { get; set; }

        public bool Validate() 
        {
            if(String.IsNullOrWhiteSpace(this.CategoryName))
            {
                throw new InvalidModelException(ErrorMessaging.CategoryError);
            }
            return true;
        }
    }
}