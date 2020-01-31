using iTuna.Umbraco.Extensions.Web.Mapping.Maps;
using iTuna.Umbraco.Extensions.Web.ViewModels;
using Umbraco.Core.Mapping;
using Umbraco.Web.PublishedModels;

namespace iTuna.Umbraco.Extensions.Web.Mapping
{
    public class HeadRestMapDefinition : IMapDefinition
    {
        public void DefineMaps(UmbracoMapper mapper)
        {
            mapper.Define<HomePage, HomePageViewModel>(HomePageViewModelMapping.Instance.Map);
            mapper.Define<FirstLevelPage, FirstLevelPageViewModel>(FirstLevelPageViewModelMapping.Instance.Map);
        }
    }
}
