namespace StaticSitesV10.Entities
{
    public class HeroItemVm : HeroItem
    {
        private readonly string _Tenant;
        public HeroItemVm(string tenantName, HeroItem hero)
        {
            _Tenant = tenantName;

            this.Title = hero.Title;
            this.SubTitle = hero.SubTitle;
            this.ImageUrl = hero.ImageUrl;
            this.ActionTitle = hero.ActionTitle;
            this.ActionUrl = hero.ActionUrl;
        }

        public string FullImageUrl { get => _Tenant + "/img/" + base.ImageUrl; }
    }
}
