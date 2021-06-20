using BookWiki.Entity;
using BookWiki.Entity.Models;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWiki.GraphQL.Queries
{
    public class Query
    {
        [UseFiltering]
        [UseSorting]
        public IQueryable<CategoryRecord> GetCategories([Service] BookWikiContext bookWikiContext) => bookWikiContext.Category.Include(x => x.Tag);
    }
    
}
