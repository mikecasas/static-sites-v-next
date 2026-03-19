using System;

namespace StaticSitesV10.Entities
{
    public class Tenant : Application
    {
        public string TenantName { get; set; }
        public Guid TenantId { get; set; }

        public string TenantIdString { get { return TenantId.ToString(); } }
    }
}
