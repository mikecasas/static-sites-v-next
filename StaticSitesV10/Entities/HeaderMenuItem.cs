using StaticSitesV10.Entities;
using System.Collections.Generic;

namespace StaticSitesV10.Entities
{
    
    public class HeaderMenuItem
    {
        public HeaderMenuLink Level1 { get; set; }
          
        public IEnumerable<HeaderMenuLink> Level2 { get; set; }
    }

    public class HeaderMenuLink
    {
        //public string FullName { get; set; }
        public string Link { get; set; }
        public string Text { get; set; }
        //public string SubTitle { get; set; }

        //public string ImageUrl { get; set; }

        //public string ActionTitle { get; set; }
    }
}