using iTuna.Umbraco.Extensions.Web.ViewModels;
using Umbraco.Core.Mapping;
using Umbraco.Web.PublishedModels;

namespace iTuna.Umbraco.Extensions.Web.Mapping.Maps
{
    public class FirstLevelPageViewModelMapping : BaseMapping<FirstLevelPageViewModelMapping, FirstLevelPage, FirstLevelPageViewModel>
    {
        public override void Map(FirstLevelPage src, FirstLevelPageViewModel dst, MapperContext ctx)
        {
            // Base mappings
            //BasePageViewModelMapper.Instance.Map(src, dst, ctx);

            // Custom maps
            dst.Title = src.Title;
        }
    }
}
