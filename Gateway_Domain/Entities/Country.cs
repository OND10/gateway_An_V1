using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateway_Domain.Entities
{
    public class Country
    {
        public int CountryId { get; set; }

        public string CountryName { get; set; } = null!;

        public string CountryCode { get; set; }=string.Empty;

        public string CountryDescription { get; set; }= string.Empty;

        




    }
}
