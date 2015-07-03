﻿namespace NSWRFS.Base.Api
{
    using System.Web.Configuration;
    using System.Web.Http;

    using NSWRFS.Base.Api.App_Start;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Auth0 Authentication handler
            var clientId = WebConfigurationManager.AppSettings["Auth0.ClientID"];
            var clientSecret = WebConfigurationManager.AppSettings["Auth0.ClientSecret"];

            config.MessageHandlers.Add(new JsonWebTokenValidationHandler
            {
                Audience = clientId,
                SymmetricKey = clientSecret
            });

            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}
