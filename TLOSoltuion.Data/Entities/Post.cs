using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TLOSoltuion.Data.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string DocumentPath { get; set; }

        [Required]
        public string DocumentType { get; set; }

        [Required]
        public int ViewCount { get; set; }

        [Required]
        public int DowloadCount { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
