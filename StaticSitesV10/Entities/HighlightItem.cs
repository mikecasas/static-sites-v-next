namespace StaticSitesV10.Entities
{
    public class HighlightItem
    {
        public string? Title { get; set; }
        public string? Descr { get; set; }

        public string? IconName { get; set; }

        //public string IconCss { get=> IconCssFontAwesome(IconName); }

        //private string IconCssFontAwesome(string? iconName)
        //{
        //    return $"fa-solid fa-{iconName} fa-stack-1x fa-inverse";
        //}
    }   
}