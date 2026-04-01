using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;

namespace api.Extensions
{
    public static class ClaimsExtensions
    {
        public static string? GetUsername(this ClaimsPrincipal user)
        {
            return user.Claims.SingleOrDefault(x =>
                x.Type == ClaimTypes.GivenName || x.Type == JwtRegisteredClaimNames.GivenName)?.Value;
        }
    }
}