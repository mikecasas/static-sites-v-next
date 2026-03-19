using System.Collections.Generic;

namespace StaticSitesV10.Entities
{
    public class SiteStructure
    {
        public bool DisplayVideo { get; set; }
        public bool DisplayStaff { get; set; }
        public bool DisplayBlog { get; set; }
        public bool DisplayContact { get; set; }
        public bool DisplayEvents { get; set; }
        public bool DisplayFooter { get; set; }
        public bool DisplayGallery { get; set; }

        public bool DisplayTopHeader { get; set; }
        public bool DisplayHeader { get; set; }
        public bool DisplayHero { get; set; }
        public bool DisplayPrices { get; set; }
        public bool DisplayProduct{ get; set; }
        public bool DisplayReservation { get; set; }
        public bool DisplayTestamonial { get; set; }

        public bool DisplayHighlights { get; set; }
        public bool DisplayAbout { get; set; }
        public bool DisplayFaq { get; set; }

        public HeroItem? HeroItem { get; set; }
        public AboutUsItem? AboutUsItem { get; set; }

        public StaffBlock? StaffBlock { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }

        public string? SiteTitle { get; set; }
        
        public string? HighlightTitle { get; set; }
        public string? HighlightSubTitle { get; set; }

        public IEnumerable<HighlightItem>? HighlightItems { get; set; }

        public string? ProductTitle { get; set; }

        public IEnumerable<IndividualProduct>? ProductItems { get; set; }

        public IEnumerable<BlogItem>? Blogs { get; set; }
        public IEnumerable<GalleryItem>? Gallery { get; set; }
        public IEnumerable<FrequentlyAskedQuestions>? FAQs { get; set; }

        public string? KeyWords { get; set; }

        public string? EmbeddedVideoUrl { get; set; }

        public PriceItem? PriceItem { get; set; }
    }
}