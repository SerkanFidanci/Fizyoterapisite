using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EntitiyLayer.Concreate
{
    public class Experience
    {
        [Key]
        public int ExperienceİD { get; set; }
        public string? Name { get; set; }
        public string? Date { get; set; }
        public string? Description { get; set; }
        public string? İmageUrl { get; set; }
    }
}
