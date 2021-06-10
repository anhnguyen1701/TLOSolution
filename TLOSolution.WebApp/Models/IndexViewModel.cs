using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TLOSoltuion.Data.Entities;

namespace TLOSolution.WebApp.Models
{
    public class IndexViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentType { get; set; }
        public int ViewCount { get; set; }
        public int DowloadCount { get; set; }
        public string PublisherName { get; set; }
        public string CategoryName { get; set; }

        public List<Category> categories { get; set; }

    }
}
