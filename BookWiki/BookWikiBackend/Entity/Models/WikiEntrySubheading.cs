using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookWiki.Entity.Abstractions;

namespace BookWiki.Entity.Models
{
    public class WikiEntrySubheadingRecord : IRecord
    {
        public WikiEntryRecord Entry { get; set; }
        [Required]
        public string SubheadingName { get; set; }
        public string EntryText { get; set;}
    } 
}