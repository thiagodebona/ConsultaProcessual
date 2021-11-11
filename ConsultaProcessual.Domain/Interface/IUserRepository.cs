using ConsultaProcessual.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConsultaProcessual.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserByRefreshToken(string refreshToken);
        Task<User> FindByUsernameAndPassword(string username, string password);
    }
}
