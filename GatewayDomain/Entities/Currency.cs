using GatewayDomain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayDomain.Entities
{
    public class Currency:AuditableEntity
    {

        [Key]
        public int CurrencyId { get; set; }
        public string CurrencyArabicName { get; set; } = string.Empty;
        public string CurrencyEnglishName { get; set; } = string.Empty;
        public string CurrencyType {  get; set; } = string.Empty;
        public string CurrencyCode { get; set; }= string.Empty;
    }
}
