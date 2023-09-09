using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RapidApiConsume.Models
{
    public class CreateToken
    {
        public string GenerateToken()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: "http://localhost",
                audience: "http://localhost",
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(3),
                signingCredentials: credentials,
                            claims: new List<Claim>
                {
                new Claim(ClaimTypes.Name, userName),
                new Claim(ClaimTypes.Role, "User"),
                new Claim("Usertype", usertype.ToString()),
                new Claim("Userid", userid.ToString())
                }
             );
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return = handler.WriteToken(token);
            

        }
    }
}
