using System.Collections.Generic;

namespace StaticSitesV10.Entities
{
    //public class ProductItem
    //{
    //    public string Category { get; set; }
      
    //    public IEnumerable<IndividualProduct> Products { get; set; }
    //}

    //public class CompleteGallery
    //{
    //    private IEnumerable<GalleryItem> items;
                    


    //    public IEnumerable<GalleryItem> GalleryItems { get; set; }

    //    public IEnumerable<GalleryItem> FullGalleryItems { get=>items; }
             
    //    public void SetValues()
    //    {
    //        if(GalleryItems is not null)
    //        {
    //            var L = new List<GalleryItem>();

    //            foreach (var i in GalleryItems)
    //            {
    //                L.Add(new GalleryItem { Descr = i.Descr, Title = i.Title, ImageUrl = "/img" + i.ImageUrl });
    //            }
    //            items = L.AsEnumerable();
    //        }           
    //    }
    //}

    public class GalleryItem
    {        
        public string Title { get; set; }
        public string Descr { get; set; }

        //public string Price { get; set; }
        public string ImageUrl { get; set; }

        public string FullImageUrl { get => "/img" + ImageUrl; }

        //public string ActionButtonUrl { get; set; }
        //public string ActionButtonText { get; set; }

        //public bool UseModal { get; set; }


    }
}