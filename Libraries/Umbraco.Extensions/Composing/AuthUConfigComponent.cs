using iTuna.Umbraco.Extensions.ViewModels;
using iTuna.Umbraco.Extensions.Web.ViewModels;
using Our.Umbraco.AuthU;
using Our.Umbraco.AuthU.Data;
using Our.Umbraco.AuthU.Services;
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
    public class AuthUConfigComponent : IComponent
    {
        public void Initialize()
        {
            //OAuth.ConfigureEndpoint("/oauth/token", new OAuthOptions
            //{
            //    UserService = new UmbracoMembersOAuthUserService(),
            //    SymmetricKey = "856FECBA3B06519C8DDDBC80BB080553",
            //    AccessTokenLifeTime = 20, // Minutes
            //    AllowInsecureHttp = true // During development only
            //});

            OAuth.ConfigureEndpoint("realm", "/oauth/token", new OAuthOptions
            {
                UserService = new UmbracoMembersOAuthUserService(),
                SymmetricKey = "856FECBA3B06519C8DDDBC80BB080553",
                AccessTokenLifeTime = 20, // Minutes
                ClientStore = new UmbracoDbOAuthClientStore(),
                RefreshTokenStore = new UmbracoDbOAuthRefreshTokenStore(),
                RefreshTokenLifeTime = 1440, // Minutes (1 day)
                AllowedOrigin = "*",
                AllowInsecureHttp = true // During development only
            });
        }

        public void Terminate() { }
    }
}
