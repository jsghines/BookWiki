
using System;
using System.ComponentModel.DataAnnotations;

namespace BookWiki.Entity.Abstractions
{
    public abstract class IUserRecord : IRecord
    {
        [MaxLength(60), Required]
        public Guid UserId { get; set; }
    }
}
