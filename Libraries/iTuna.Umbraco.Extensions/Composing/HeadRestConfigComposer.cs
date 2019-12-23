using iTuna.Umbraco.Extensions.Web.Mapping;
using Our.Umbraco.HeadRest.Composing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Mapping;

namespace iTuna.Umbraco.Extensions.Composing
{
    //public class HeadRestConfigComposer : ComponentComposer<HeadRestConfigComponent>
    //{ }

    [ComposeAfter(typeof(HeadRestComposer))]
    public class HeadRestConfigComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components()
                .Append<HeadRestConfigComponent>();

            composition.WithCollectionBuilder<MapDefinitionCollectionBuilder>()
                .Add<HeadRestMapDefinition>();
        }
    }
}
