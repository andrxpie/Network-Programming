﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_license_plate__CLP__DB
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Brand> Brands { get; set; }
    }
}
