﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EntitiyLayer.Concreate
{
    public class Feature
    {
        [Key]
        public int FeatureİD { get; set; }
        public string? Header { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
    }
}
