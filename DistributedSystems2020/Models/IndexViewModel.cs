using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace DistributedSystems2020.Models {
    public class IndexViewModel {
        public string Title { get; set; }
        public string Keyword { get; set; }

        public string Description { get; set; }

        public NewsModel News { get; set; }
        public CovidModel Covid { get; set; }

    }
}