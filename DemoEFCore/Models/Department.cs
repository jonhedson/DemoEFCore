﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DemoEFCore.Models
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
        }

        [MaxLength(50)]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
