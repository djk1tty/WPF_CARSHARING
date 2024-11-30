using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp6.DbConnector;
using WpfApp6.Models;

namespace WpfApp6
{
    public class UserService
    {
        private readonly Kolokolcev223ToysShopDb _context;

        public UserService(Kolokolcev223ToysShopDb context)
        {
            _context = context;
        }

        public async Task<bool> IsLoginUniqueAsync(string login)
        {
            return !await _context.Users.AnyAsync(u => u.Login == login);
        }

        public async Task SaveUserAsync(string login, string password)
        {
            using (var dbContext = new Kolokolcev223ToysShopDb())
            {
                var user = new User()
                {
                    Login = login,
                    Password = password,

                };

                dbContext.Users.Add(user);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<bool> UserLoginAsync(string login, string password)
        {
            using (var dbContext = new Kolokolcev223ToysShopDb())
            {
                var user = await dbContext.Users.SingleOrDefaultAsync(u => u.Login == login);

                if (user == null)
                {
                    return false;
                }

                return user.Password == password;
            }
        }
    }

}
