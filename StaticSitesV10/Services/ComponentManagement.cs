using StaticSitesV10.Components.MikeCustom.Heros;
using StaticSitesV10.Entities;

namespace StaticSitesV10.Services
{   
    public class ComponentMetadata
    {
        public required Type Type { get; init; }
        public required string Name { get; init; }
        public Dictionary<string, object> Parameters { get; } = [];
    }

    public class ComponentManagement
    {
        public Dictionary<string, ComponentMetadata> GetHeroComponents(HeroItem hero)
        {
            Dictionary<string, ComponentMetadata> components =
              new()
              {
                  [nameof(LargeHero)] = new ComponentMetadata()
                  {
                      Type = typeof(LargeHero),
                      Name = "Large Hero",
                      Parameters = { [nameof(LargeHero.HeroItem)] = hero }
                  },
                  [nameof(RightAligned)] = new ComponentMetadata()
                  {
                      Type = typeof(RightAligned),
                      Name = "Right Aligned",
                      Parameters = { [nameof(RightAligned.HeroItem)] = hero }
                  },
                  [nameof(Centered)] = new ComponentMetadata()
                  {
                      Type = typeof(Centered),
                      Name = "Centered",
                      Parameters = { [nameof(Centered.HeroItem)] = hero }
                  },
                  [nameof(Rounded)] = new ComponentMetadata()
                  {
                      Type = typeof(Rounded),
                      Name = "Rounded",
                      Parameters = { [nameof(Rounded.HeroItem)] = hero }
                  },
                  [nameof(MediumHero)] = new ComponentMetadata()
                  {
                      Type = typeof(MediumHero),
                      Name = "Medium Hero",
                      Parameters = { [nameof(MediumHero.HeroItem)] = hero }
                  },

                  [nameof(MoreText)] = new ComponentMetadata()
                  {
                      Type = typeof(MoreText),
                      Name = "More Text",
                      Parameters = { [nameof(MoreText.HeroItem)] = hero }
                  },

                  [nameof(Video)] = new ComponentMetadata()
                  {
                      Type = typeof(Video),
                      Name = "Video",
                      Parameters = { [nameof(Video.HeroItem)] = hero }
                  },

                  [nameof(Layout230)] = new ComponentMetadata()
                  {
                      Type = typeof(Layout230),
                      Name = "230",
                      Parameters = { [nameof(Layout230.HeroItem)] = hero }
                  },

                  [nameof(Layout240)] = new ComponentMetadata()
                  {
                      Type = typeof(Layout240),
                      Name = "240",
                      Parameters = { [nameof(Layout240.HeroItem)] = hero }
                  },
              };

            return components;
        }       
    }
}