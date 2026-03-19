
namespace StaticSitesV10.Entities
{
    public class AboutUsItemVm : AboutUsItem
    {
        private readonly string _Tenant;
        public AboutUsItemVm(string tenantName, AboutUsItem about)
        {
            _Tenant = tenantName;
            this.Title = about.Title;
            this.SubTitle = about.SubTitle;
            this.Item1Description = about.Item1Description;
            this.Item2Description = about.Item2Description;
            this.MainImageUrl = about.MainImageUrl;
            this.SubImageUrl = about.SubImageUrl;
            this.ItemList = about.ItemList;
            this.ListHeader = about.ListHeader;
            this.ListFooter = about.ListFooter;
            this.Item1Title = about.Item1Title;
            this.Item2Title = about.Item2Title;
        }

        public string FullMainImageUrl { get => _Tenant + "/img/" + MainImageUrl; }
        public string FullSubImageUrl { get => _Tenant + "/img/" + SubImageUrl; }    

    }
}