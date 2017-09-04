using System;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.IdentityModel.Tokens;
using CustomTokenAuthProvider;
using Microsoft.Extensions.Options;
using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace campanhabrinquedo.webapi
{
    //public class Startup
    //{
    //    private void ConfigureAuth(IApplicationBuilder app)
    //    {
    //        var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("TokenAuthentication:SecretKey").Value));

    //        var tokenValidationParameters = new TokenValidationParameters
    //        {
    //            ValidateIssuerSigningKey = true,
    //            IssuerSigningKey = signingKey,
    //            ValidateIssuer = true,
    //            ValidIssuer = Configuration.GetSection("TokenAuthentication:Audience").Value,
    //            ValidateLifetime = true,
    //            ClockSkew = TimeSpan.Zero
    //        };

    //        app.UseJwtBearerAuthentication(new JwtBearerOptions
    //        {
    //            AutomaticAuthenticate = true,
    //            AutomaticChallenge = true,
    //            TokenValidationParameters = tokenValidationParameters
    //        });

    //        app.UseCookieAuthentication(new CookieAuthenticationOptions
    //        {
    //            AutomaticAuthenticate = true,
    //            AutomaticChallenge = true,
    //            AuthenticationScheme = "Cookie",
    //            CookieName = Configuration.GetSection("TokenAuthentication:CookieName").Value,
    //            TicketDataFormat = new CustomJwtDataFormat(SecurityAlgorithms.HmacSha256, tokenValidationParameters)
    //        });

    //        var tokenProviderOptions = new TokenProviderOptions
    //        {
    //            Path = Configuration.GetSection("TokenAuthentication:TokenPath").Value,
    //            Audience = Configuration.GetSection("TokenAuthentication:Audience").Value,
    //            Issuer = Configuration.GetSection("TokenAuthentication:Issuer").Value,
    //            SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256),
    //            IdentityResolver = GetIdentity
    //        };
    //        app.UseMiddleware<TokenProviderMiddleware>(Options.Create(tokenProviderOptions));
    //    }

    //    private Task<ClaimsIdentity> GetIdentity(string username, string password, IUsuarioService usuarioService)
    //    {
    //        if (usuarioService.LogarUsuario(username, password))
    //            return Task.FromResult(new ClaimsIdentity(new GenericIdentity(username, "Token"), new Claim[] { }));

    //        return Task.FromResult<ClaimsIdentity>(null);
    //    }
    //}
}