using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateway_Domain.Entities
{
    public class City
    {

        [Key]
        public int CityId { get; set; }

        public string CityName { get; set; } = null!;

        public string CityDescription { get; set; } = string.Empty;

    }
}
