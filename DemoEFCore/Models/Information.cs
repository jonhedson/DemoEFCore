using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEFCore.Models
{
    public class Information
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string License { get; set; }

        public DateTime Established { get; set; }

        public decimal Revenue { get; set; }

    }
}
