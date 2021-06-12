using System.Collections.Generic;

namespace TLOSolution.WebApp.Models
{
    public class SearchReponseViewModel : SearchBaseViewModel
    {
        public List<PostViewModel> Posts { get; set; }

        public string InputString { get; set; }
    }
}
