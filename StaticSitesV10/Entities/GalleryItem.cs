
namespace StaticSitesV10.Entities
{
    public class GalleryItem
    {
        public string? Title { get; set; }
        public string? Descr { get; set; }

        public string? ImageUrl { get; set; }
    }

    public class GalleryItemVm : GalleryItem
    {
        private readonly string _Tenant;

        public GalleryItemVm(string tenantName, GalleryItem galleryItem)
        {
            _Tenant = tenantName;
            this.Title = galleryItem.Title;
            this.Descr = galleryItem.Descr;
            this.ImageUrl = galleryItem.ImageUrl;
        }

        public string? FullImageUrl { get => _Tenant + "/img/" + ImageUrl; }
    }
}