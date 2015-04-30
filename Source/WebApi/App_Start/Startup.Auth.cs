using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.OAuth;
using Owin;
using WebApi.Providers;
using WebApi.Models;
using System.Threading.Tasks;
using System.Configuration;
using WebApi.Models;
using WebApi.Providers;

namespace WebApi
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public static OAuthBearerAuthenticationOptions OAuthBearerOptions { get; private set; }
        
        public static Func<UserManager<ApplicationUser>> UserManagerFactory { get; set; }

        public static string PublicClientId { get; private set; }

        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context and user manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseCookieAuthentication(new CookieAuthenticationOptions());
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Configure the application for OAuth based flow
            PublicClientId = "self";
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/Token"),
                Provider = new ApplicationOAuthProvider(PublicClientId),
                AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                AllowInsecureHttp = true
            };

            OAuthBearerOptions = new OAuthBearerAuthenticationOptions();
            OAuthBearerOptions.AccessTokenFormat = OAuthOptions.AccessTokenFormat;
            OAuthBearerOptions.AccessTokenProvider = OAuthOptions.AccessTokenProvider;
            OAuthBearerOptions.AuthenticationMode = OAuthOptions.AuthenticationMode;
            OAuthBearerOptions.AuthenticationType = OAuthOptions.AuthenticationType;
            OAuthBearerOptions.Description = OAuthOptions.Description;
            OAuthBearerOptions.Provider = new CustomBearerAuthenticationProvider();
            OAuthBearerOptions.SystemClock = OAuthOptions.SystemClock;

            // Enable the application to use bearer tokens to authenticate users
            app.UseOAuthBearerTokens(OAuthOptions);
            OAuthBearerAuthenticationExtensions.UseOAuthBearerAuthentication(app, OAuthBearerOptions);

            // Uncomment the following lines to enable logging in with third party login providers
            //app.UseMicrosoftAccountAuthentication(
            //    clientId: "",
            //    clientSecret: "");

            //app.UseTwitterAuthentication(
            //    consumerKey: "",
            //    consumerSecret: "");

            app.UseFacebookAuthentication(
                appId: ConfigurationManager.AppSettings["facebookAppId"],
                appSecret: ConfigurationManager.AppSettings["facebookAppSecret"]);

            /*app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions
            {
                ClientId = "79011049554-0ck6n5t46ckpr168ip6biv0dmicbphpj.apps.googleusercontent.com",
                ClientSecret = "4Du6V1xAX9IuU28iKSg3I4dM"
            });*/
        }
    }

    public class CustomBearerAuthenticationProvider : OAuthBearerAuthenticationProvider
    {
        public override Task ValidateIdentity(OAuthValidateIdentityContext context)
        {
            var claims = context.Ticket.Identity.Claims;
            if (claims.Count() == 0 || claims.Any(claim => claim.Issuer != "Facebook" && claim.Issuer != "LOCAL_AUTHORITY"))
                context.Rejected();
            return Task.FromResult<object>(null);
        }
    }

}
