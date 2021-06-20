using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWiki.Entity.Abstractions
{
    public abstract class IRecord
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        public DateTime InsertedDate { get; set; }

        [MaxLength(60)]
        public string InsertedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        [MaxLength(60)]
        public string UpdatedBy { get; set; }
    }
}
