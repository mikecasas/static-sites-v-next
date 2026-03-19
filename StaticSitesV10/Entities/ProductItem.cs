
namespace StaticSitesV10.Entities
{
    public class ProductGroup
    {
        private IEnumerable<IndividualProduct>? items;

        public string? LeadingPath { get; set; }

        public string? Category { get; set; }

        public IEnumerable<IndividualProduct>? FullProducts { get=> items; }
        public IEnumerable<IndividualProduct>? Products { get; set; }

        public void SetValues()
        {
            if (Products is not null)
            {
                var L = new List<IndividualProduct>();

                foreach (var i in Products)
                {
                    string CompleteImageFile = "";
                    if (i.ImageUrl.Contains("https://"))
                        CompleteImageFile = i.ImageUrl;
                    else
                        CompleteImageFile = LeadingPath + "/img/" + i.ImageUrl;

                    L.Add(new IndividualProduct { Descr = i.Descr, Title = i.Title, Price=i.Price, ActionButtonText=i.ActionButtonText,
                        ActionButtonUrl=i.ActionButtonUrl, UseModal=i.UseModal, ImageUrl = CompleteImageFile });
                }
                items = L.AsEnumerable();
            }
        }
    }

    public class IndividualProduct
    {        
        public string? Title { get; set; }
        public string? Descr { get; set; }

        public string? Price { get; set; }
        public string? ImageUrl { get; set; }

        public string? ActionButtonUrl { get; set; }
        public string? ActionButtonText { get; set; }

        public bool UseModal { get; set; }
    }
}