using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Northwind.Entity.Dto;

namespace Northwind.Bll.Concrete
{
    public class TokenManager
    {
        private IConfiguration _configuration;

        public TokenManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Create Token Method
        public string CreateAccessToken(DtoLoginUser user)
        {
            // Create Claims
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserCode),
                new Claim(JwtRegisteredClaimNames.Jti, user.UserId.ToString())
            };

            // Create Claims Identity
            var claimsIdentity = new ClaimsIdentity(claims, "Token");
            
            // Claims Roles
            var claimsRoles = new List<Claim>()
            {
                new Claim("role", "Admin"),
                // new Claim("role", "")
            };

            // Get Symmetric Key 
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));

            // Create Encrypted Identity
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            // Token Settings
            var token = new JwtSecurityToken(
                issuer: _configuration["Tokens:Issuer"], //Token Publish Url
                audience: _configuration["Tokens:Issuer"], // Access Api's
                expires: DateTime.Now.AddMinutes(5), // Token Life Time
                notBefore:DateTime.Now, // Start Time of Token Life Time 
                signingCredentials:cred, // Identity
                claims:claimsIdentity.Claims // Set Claims
            );

            // Create Token
            var tokenHandler = new {token = new JwtSecurityTokenHandler().WriteToken(token)};
            
            return tokenHandler.token;
        } 
    }
}