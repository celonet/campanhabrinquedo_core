using Microsoft.IdentityModel.Tokens;
using System;

namespace campanhabrinquedo.webapi.Middleware
{   
    public class TokenProviderOptions
    {
        public string Path { get; set;} = "/api/token";
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public TimeSpan Expiration { get; set; } = TimeSpan.FromSeconds(3600);
        public SigningCredentials SigningCredentials { get; set; }
    }
}