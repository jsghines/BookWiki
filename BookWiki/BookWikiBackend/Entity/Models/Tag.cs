using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookWiki.Entity.Abstractions;

namespace BookWiki.Entity.Models
{
    public class TagRecord : IUserRecord
    {
      [Required]
      public string TagName { get; set; }  
    } 
}