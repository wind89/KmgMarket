using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMarket.DAL.Models
{
    public class ProductProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [Required]
        public Guid CategoryPropertyId { get; set; }

        public string Value { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public virtual Product Product { get; set; }

        [ForeignKey("CategoryPropertyId")]
        public virtual CategoryProperty CategoryProperty { get; set; }
    }
}
