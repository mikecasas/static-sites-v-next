using System.Collections.Generic;

namespace StaticSitesV10.Entities
{
    public class PriceItem
    {
        //public string FullName { get; set; }
        public string? Title { get; set; }
        public string? Descr { get; set; }


        public string? PriceTitle { get; set; }
        public string? ActualPrice { get; set; }

        public bool IsFeatured { get; set; }

        public string? Icon { get; set; }

        public IEnumerable<string>? FeatureCallouts { get; set; }
    }
}
