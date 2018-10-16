using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMarket.DAL.Models
{
    public class CategoryProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public bool Nullable { get; set; }


        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
