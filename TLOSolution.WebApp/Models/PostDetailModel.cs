﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLOSolution.WebApp.Models
{
    public class PostDetailModel : SearchBaseViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DocumentPath { get; set; }
        public string PublisherName { get; set; }
        public int ViewCount { get; set; }
        public int DowloadCount { get; set; }

    }
}
