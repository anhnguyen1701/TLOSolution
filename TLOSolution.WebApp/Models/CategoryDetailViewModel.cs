using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLOSolution.WebApp.Models
{
    public class CategoryDetailViewModel : SearchBaseViewModel
    {
        public List<PostViewModel> Posts { get; set; }
    }
}
