using ConsultaProcessual.Domain.Entities;
using System.Text.Json.Serialization;

namespace ConsultaProcessualAPI.Models
{
    public class AuthenticateResponse
    {
        public string Username { get; set; }
        public string JwtToken { get; set; }
        [JsonIgnore] // refresh token is returned in http only cookie
        public string RefreshToken { get; set; }

        public AuthenticateResponse(User user, string jwtToken, string refreshToken)
        {
            Username = user.Username;
            JwtToken = jwtToken;
            RefreshToken = refreshToken;
        }
    }
}