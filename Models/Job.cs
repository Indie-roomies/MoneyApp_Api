using System;
using System.Collections.Generic;

namespace MoneyApp_Api.Models
{
    public partial class Job
    {
        public long IdTask { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? Completed { get; set; }
    }
}
