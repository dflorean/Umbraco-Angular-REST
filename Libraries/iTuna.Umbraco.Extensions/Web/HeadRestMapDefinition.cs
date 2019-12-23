using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Composing;
using Umbraco.Core.Mapping;
using Umbraco.Web.PublishedModels;

namespace iTuna.Umbraco.Extensions.ViewModels
{
    //public class MyHeadRestMapDefinition : IMapDefinition
    //{
    //    public void DefineMaps(UmbracoMapper mapper)
    //    {
    //        mapper.Define<HomePage, HomePageViewModel>(
    //            (frm, ctx) => { frm.Title = ctx.Title; },      // Constructor function
    //            (frm, to, ctx) => ...   // Map function
    //    }
    //}

    //public class MyHeadRestMapDefinisionComposer : IUserComposer
    //{
    //    public void Compose(Composition composition)
    //    {
    //        composition.WithCollectionBuilder<MapDefinitionCollectionBuilder>()
    //            .Add<MyHeadRestMapDefinition>();
    //    }
    //}
}
