using ConsultaProcessual.Domain.Entities;
using ConsultaProcessual.Service.Services;
using ConsultaProcessualAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsultaProcessual.Service.Interfaces
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        AuthenticateResponse RefreshToken(string token, string ipAddress);
        bool RevokeToken(string token, string ipAddress);
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(Guid id);
    }
}