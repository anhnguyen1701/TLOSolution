using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLOSolution.WebApp.Models
{
    public class SearchPostViewModel
    {
        public List<SelectOptionCateogryViewModel> CategoryHolder { get; set; }

        public SearchPostCondition Condition { get; set; }

    }
    public class SearchPostCondition
    {
        public string InputString { get; set; }
        public int? CategoryHolder { get; set; }
    }
}
