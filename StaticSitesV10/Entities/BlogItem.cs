using System;

namespace StaticSitesV10.Entities
{
    public class BlogItem
    {
        //public string FullName { get; set; }
        public string? Title { get; set; }
        public string? Descr { get; set; }
        public DateTime ReleasedOn { get; set; }

        public string? Url { get; set; }
        public string? ButtonText { get; set; }
    }   
}