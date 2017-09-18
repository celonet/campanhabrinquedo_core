using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace campanhabrinquedo.webapi.Middleware
{
    public static class TokenProviderMiddlewareExtensions
    {
        public static IApplicationBuilder UseJWTTokenProviderMiddleware(this IApplicationBuilder builder, IOptions<TokenProviderOptions> options)
        {
            return builder.UseMiddleware<TokenProviderMiddleware>(options);
        }
    }
}