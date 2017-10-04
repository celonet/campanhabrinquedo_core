using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using campanhabrinquedo.webapi.Model;

namespace campanhabrinquedo.webapi.Middleware
{
    public class TokenProviderMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly TokenProviderOptions _options;
        private readonly IUsuarioService _usuarioService;

        public TokenProviderMiddleware(RequestDelegate next, IOptions<TokenProviderOptions> options, IUsuarioService usuarioService)
        {
            _next = next;
            _options = options.Value;
            _usuarioService = usuarioService;
        }

        public Task Invoke(HttpContext context)
        {
            if (!context.Request.Path.Equals(_options.Path, StringComparison.Ordinal))
                return _next(context);

            if (context.Request.Method.Equals("POST") && context.Request.HasFormContentType)
                return GenerateToken(context);
            context.Response.StatusCode = 400;
            return context.Response.WriteAsync("Bad Request");
        }

        private async Task GenerateToken(HttpContext context)
        {
            string username = context.Request.Form["username"];
            string password = context.Request.Form["password"];

            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Invalid username or password");
                return;
            }

            var result = _usuarioService.LogarUsuario(username, password);
            if (result)
            {
                var now = DateTime.UtcNow;

                var jwt = new JwtSecurityToken(
                    _options.Issuer,
                    _options.Audience,
                    notBefore: now,
                    expires: now.Add(_options.Expiration),
                    signingCredentials: _options.SigningCredentials);

                var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

                var response = new
                {
                    access_token = encodedJwt,
                    expires_in = (int)_options.Expiration.TotalSeconds
                };

                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(JsonConvert.SerializeObject(response, new JsonSerializerSettings { Formatting = Formatting.Indented }));
            }
            else
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Invalid username or password");
            }
        }
    }
}