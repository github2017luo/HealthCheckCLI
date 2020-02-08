using System;
using System.Collections.Generic;
using System.Data.Common;

namespace HealthCheckCLI.Models
{
    public class DataItem
    {
        public string Id { get; set; }
    }
    public class Data
    {
        public IList<Group> Groups { get; set; }
        public IList<Url> Urls { get; set; }
    }
}