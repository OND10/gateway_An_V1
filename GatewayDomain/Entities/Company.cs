using GatewayDomain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateway_Domain.Entities
{
    public class Company
    {

        public Company()
        {
            CompanyServiceslist = new HashSet<CompanyServices>();   
        }


        [Key]
        public int CompanyId { get; set; }
        public string CompanyName_English { get; set; } = "";
        public string CompanyName_Arabic { get; set; } = "";
        public string CompanyDescription { get; set; } = string.Empty;
        public string CompanyPhone { get; set; } = string.Empty;
        public string CompanyEmail { get; set; } = string.Empty;
        public string? CompanyAddress { get; set; }

        [NotMapped]
        public IFormFile Companylogo { get; set; }
        public string LogoUrl { get; set; } = string.Empty;
        public int CityId { get; set; }
        public bool State { get; set; }
        public int CountryId { get; set; }
        public int ProviderId { get; set; }
        public string ProviderName { get; set; } = string.Empty;
        public string ProvidePhoneNumber { get; set; } = string.Empty;
        public string ProviderEmail { get; set; } = string.Empty;
        public int CategoryID { get; set; }
        public int ProvinceId {  get; set; }

        [InverseProperty(nameof(CompanyServices.company))]
        public ICollection<CompanyServices> CompanyServiceslist { get; set; }

    }

}
