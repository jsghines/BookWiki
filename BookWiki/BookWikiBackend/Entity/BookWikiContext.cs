using System.Collections.Generic;
using BookWiki.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWiki.Entity
{
    public class BookWikiContext : DbContext
    {
        public BookWikiContext()
        {}
        public BookWikiContext(DbContextOptions<BookWikiContext> options) : base(options)
        {}
        public DbSet<CategoryRecord> Category { get; set; }
        public DbSet<TagRecord> Tag { get; set; }
        public DbSet<WikiEntryRecord> WikiEntry { get; set; }
        public DbSet<WikiEntrySubheadingRecord> WikiEntrySubheading { get; set; }
        public DbSet<WikiEntryTagRecord> WikiEntryTag { get; set; }
    }
}