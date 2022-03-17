using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEFCore.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string TelephoneNo { get; set; }
        public string Email { get; set; }
    }
}
