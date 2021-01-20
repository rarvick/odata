using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public int Year { get; set; }
    }
}
