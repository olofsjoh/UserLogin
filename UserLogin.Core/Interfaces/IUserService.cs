using System;

namespace UserLogin.Core.Interfaces
{
    public interface IUserService
    {
        bool HasValidCredentials(string userName, string password);
    }
}
