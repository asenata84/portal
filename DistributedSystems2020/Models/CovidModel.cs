using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistributedSystems2020.Models
{
    public class CovidModel
    {
        public Response[] Response { get; set; }
    }

    public class Response
    {
        public Cases cases { get; set; }
        public Deaths deaths { get; set; }
    }
    public class Cases
    {
        public string total { get; set; }
        public string confirmed { get; set; }
        public string recovered { get; set; }
        public string critical { get; set; }
        public string active { get; set; }
    }
    public class Deaths
    {
        public string total { get; set; }

    }
}