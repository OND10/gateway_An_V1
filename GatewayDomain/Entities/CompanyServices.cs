using Gateway_Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayDomain.Entities
{
    public class CompanyServices
    {

        [Key]
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ServiceId { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Company.CompanyServices))]
        public Company company { get; set; } = null!;

        [ForeignKey(nameof(ServiceId))]
        [InverseProperty(nameof(Services.CompanyServices))]
        public Services service { get; set; } = null!;



    }
}
