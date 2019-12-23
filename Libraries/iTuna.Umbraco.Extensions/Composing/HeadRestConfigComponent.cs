using iTuna.Umbraco.Extensions.ViewModels;
using iTuna.Umbraco.Extensions.Web.ViewModels;
using Our.Umbraco.HeadRest;
using Our.Umbraco.HeadRest.Web.Mapping;
using Our.Umbraco.HeadRest.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Composing;
using Umbraco.Web.PublishedModels;

namespace iTuna.Umbraco.Extensions.Composing
{
    public class HeadRestConfigComponent : IComponent
    {
        private readonly HeadRest _headRest;

        public HeadRestConfigComponent(HeadRest headRest)
            => _headRest = headRest;

        public void Initialize()
        {
            // Configuration goes here
            _headRest.ConfigureEndpoint("/api/", "/root//homePage[1]", new HeadRestOptions
            {
                
                //CustomRouteMappings = new HeadRestRouteMap()
                //    .For("^/(.*)?$").MapTo("/"),

                ViewModelMappings = new HeadRestViewModelMap()
                .For(HomePage.ModelTypeAlias).MapTo<HomePageViewModel>()
                .For(FirstLevelPage.ModelTypeAlias).MapTo<FirstLevelPageViewModel>()
            }); ;
        }

        public void Terminate() { }
    }
}
