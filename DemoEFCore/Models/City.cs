using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEFCore.Models
{

    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CityInformationId { get; set; }

        public CityInformation CityInformation { get; set; }
    }
}
