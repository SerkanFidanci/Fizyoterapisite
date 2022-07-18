using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EntitiyLayer.Concreate
{
    public class About
    {
        [Key]
        public int AboutİD { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Age { get; set; }
        public string? Mail { get; set; }
        public string? Phone { get; set; }
        public string? Adress { get; set; }
        public string? İmageUrl { get; set; }
    }
}
