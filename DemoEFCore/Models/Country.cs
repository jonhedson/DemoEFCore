using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEFCore.Models
{
    
    public class Country
    {
        
        public int Id { get; set; }

       
        public string Name { get; set; }

        public ICollection<City> City { get; set; }
    }
}
