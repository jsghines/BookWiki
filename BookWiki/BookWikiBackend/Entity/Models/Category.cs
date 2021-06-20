using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookWiki.Entity.Abstractions;

namespace BookWiki.Entity.Models
{
    public class CategoryRecord : IRecord
    {
        public TagRecord Tag { get; set; }
    } 
}