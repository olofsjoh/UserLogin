using System;
using UserLogin.Core;
using UserLogin.Infrastructure.Logger;
using UserLogin.Infrastructure.Repositories;

namespace UserLogin.Infrastructure.Factories
{
    public static class UserFactory
    {
        public static UserService Create()
        {
            return new UserService(new UserRepository(new UserContext()), new DebugLogger());
        }
       
    }
}
