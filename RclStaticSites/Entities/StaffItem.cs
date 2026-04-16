using Microsoft.AspNetCore.Components;

namespace RclStaticSites.Entities
{
    public class StaffItem
    {
        public string? FullName { get; set; }
        public string? Title { get; set; }
        public string? Descr { get; set; }

        public string? ImageUrl { get; set; }        
    }

    public class StaffItemVm : StaffItem
    {
        private readonly string _Tenant;

        public StaffItemVm(string tenantName, StaffItem staff)
        {
            _Tenant = tenantName;
            this.Descr = staff.Descr;
            this.Title = staff.Title;
            this.ImageUrl = staff.ImageUrl;
            this.FullName = staff.FullName;
        }

        public string FullImageUrl { get => _Tenant + "/img/" + ImageUrl; }
    }

    public class StaffBlock
    {
        public IEnumerable<StaffItemVm>? StaffPeople { get; set; }

        public string? Title { get; set; }

        public string? SubTitle { get; set; }
    }
}