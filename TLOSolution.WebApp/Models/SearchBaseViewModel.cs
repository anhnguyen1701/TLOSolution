using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLOSolution.WebApp.Models
{
    public class SearchBaseViewModel
    {
        public List<CategoryViewModel> Categories { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryTitle { get; set; }
    }
}
