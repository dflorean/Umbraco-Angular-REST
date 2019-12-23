using iTuna.Umbraco.Extensions.Web.ViewModels;
using Umbraco.Core.Mapping;
using Umbraco.Web.PublishedModels;

namespace iTuna.Umbraco.Extensions.Web.Mapping.Maps
{
    public class HomePageViewModelMapping : BaseMapping<HomePageViewModelMapping, HomePage, HomePageViewModel>
    {
        public override void Map(HomePage src, HomePageViewModel dst, MapperContext ctx)
        {
            // Base mappings
            //BasePageViewModelMapper.Instance.Map(src, dst, ctx);

            // Custom maps
            dst.Title = src.Title;
        }
    }
}
