using System;

namespace StaticSitesV10.Entities
{
    public class Application
    {
        public string AppName { get; set; }

        public int AppNbr { get; set; }

        public string AppDescr { get; set; }
        public Guid AppId { get; set; }

        public string FriendlyAppName { get; set; }
    }
}
