
namespace StaticSitesV10.Entities
{
    public class AboutUsItem
    {
        public string? Title { get; set; }
        public string? SubTitle { get; set; }

        public IEnumerable<string>? ItemList { get; set; }

        public string? ListHeader { get; set; }
        public string? ListFooter { get; set; }

        public string? MainImageUrl { get; set; }
        public string? SubImageUrl { get; set; }

        public string? Item1Title { get; set; }
        public string? Item2Title { get; set; }

        public string? Item1Description { get; set; }
        public string? Item2Description { get; set; }
    }
}