using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookWiki.Entity.Abstractions;

namespace BookWiki.Entity.Models
{
    public class WikiEntryRecord : IRecord
    {
        public CategoryRecord Category { get; set; }
        [Required]
        public string EntryName { get; set; }
    } 
}