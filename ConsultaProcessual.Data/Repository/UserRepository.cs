using ConsultaProcessual.Data.Context;
using ConsultaProcessual.Domain.Entities;
using ConsultaProcessual.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaProcessual.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context) { }

        public async Task<User> GetUserByRefreshToken(string token)
        {
            return await Db.Users.AsNoTracking().SingleOrDefaultAsync(u => u.RefreshTokens.Any(t => t.Token == token));
        }

        public async Task<User> FindByUsernameAndPassword(string username, string password)
        {
            return await Db.Users.AsNoTracking().SingleOrDefaultAsync(x => x.Username == username && x.Password == password);
        }
    }
}
