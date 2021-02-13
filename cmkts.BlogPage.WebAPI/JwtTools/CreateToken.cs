using cmkts.BlogPage.Entity.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace cmkts.BlogPage.WebAPI.JwtTools
{
    public class CreateToken
    {
        public JwtToken GenerateJwtToken(User user)
        {
            SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWTInfo.JwtInfos.SecurityKey));
            SigningCredentials signingCredentials = new SigningCredentials(symmetricSecurityKey, algorithm: SecurityAlgorithms.HmacSha256);
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(JWTInfo.JwtInfos.Issuer, JWTInfo.JwtInfos.Audience, SetClaim(user), notBefore: DateTime.Now,expires:DateTime.Now.AddHours(1),signingCredentials:signingCredentials);
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            JwtToken jwtToken = new JwtToken();
            jwtToken.Token=handler.WriteToken(jwtSecurityToken);
            return jwtToken;
        }

        private List<Claim> SetClaim(User user)
        {
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Name , user.Email));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Email));
            return claims;
        }
    }
}
