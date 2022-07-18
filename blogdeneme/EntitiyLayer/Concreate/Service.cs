using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntitiyLayer.Concreate
{
    public class Service
    {
        [Key]
        public int ServiceİD { get; set; }
        public string? Title { get; set; }
        public string? İmageUrl { get; set; }
    }
}
