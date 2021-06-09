using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TLOSolution.WebApp.Models
{
    public class PostCreateModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Chọn một file")]
        [DataType(DataType.Upload)]
        [FileExtensions(Extensions = "pdf")]
        [Display(Name = "Chọn file upload")]
        public IFormFile DocumentPath { get; set; }
    }
}
