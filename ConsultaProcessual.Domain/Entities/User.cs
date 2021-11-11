using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConsultaProcessual.Domain.Entities
{
    public class User : Entity
    {
        public string Username { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public DateTime DateRegister { get; set; }
        public bool Active { get; set; }

        [JsonIgnore]
        public List<RefreshToken> RefreshTokens { get; set; }
    }
}
