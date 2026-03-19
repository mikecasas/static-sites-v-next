using Microsoft.AspNetCore.Components;

namespace StaticSitesV10.Entities
{
    public class StaffItem
    {
        public string? FullName { get; set; }
        public string? Title { get; set; }
        public string? Descr { get; set; }

        public string? ImageUrl { get; set; }
        public string FullImageUrl { get => $"all/img/staff/{ImageUrl}"; }
    }


    public class StaffBlock
    {
        public IEnumerable<StaffItem>? StaffPeople { get; set; }

        public string? Title { get; set; }

        public string? SubTitle { get; set; }
    }
}
