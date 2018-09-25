using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin.Core.Model;
using UserLogin.Core.Interfaces;

namespace UserLogin.Infrastructure.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public User GetUser(string userName)
        {
            return _context.Users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
