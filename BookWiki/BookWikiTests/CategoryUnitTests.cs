using System;
using BookWiki.Domain.Models;
using BookWiki.Helpers.Errors;
using Xunit;

namespace BookWikiTests
{
    public class CategoryUnitTests
    {
        [Fact]
        public void ValidationSucceeds()
        {
            var categoryModel = new CategoryItem()
            {
                CategoryName = "test"
            };
            Assert.True(categoryModel.Validate());
        }
        [Fact]
        public void ValidationThrowsException()
        {
            var categoryModel = new CategoryItem();
            Action act = () => categoryModel.Validate();
            Assert.Throws<InvalidModelException>(act);
        }
    }
}
