using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayDomain.Common
{
    public class AuditableEntity
    {
        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public DateTime LastModifiedOn { get; set; }

        public DateTime DeletedOn { get; set; }

        public bool IsActive { get; set; } = false;

    }
}
