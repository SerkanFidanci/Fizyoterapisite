using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EntitiyLayer.Concreate
{
    public class Portfolio
    {
        [Key]
        public int PortfolioİD { get; set; }
        public string? Name { get; set; }
        public string? İmageUrl { get; set; }
    }
}
