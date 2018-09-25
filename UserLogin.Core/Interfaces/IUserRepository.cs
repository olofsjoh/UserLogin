using System;
using UserLogin.Core.Model;

namespace UserLogin.Core.Interfaces
{
    public interface IUserRepository
    {
        User GetUser(string userName);
    }
}
