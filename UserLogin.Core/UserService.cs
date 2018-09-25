using System;
using UserLogin.Core.Interfaces;
using UserLogin.Core.Model;

namespace UserLogin.Core
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly ILogger _logger;

        public UserService(IUserRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public bool HasValidCredentials(string userName, string password)
        {
            if (userName == string.Empty || password == string.Empty)
                return false;

            var user = GetUser(userName);
            if (user == null) return false;

            return VerifyCredentials(password, user);
        }

        private User GetUser(string userName)
        {
            var user = _repository.GetUser(userName);
            if (user == null)
            {
                _logger.Warning($"Username {userName} not found");
                return null;
            }
            return user;
        }

        private bool VerifyCredentials(string password, User user)
        {
            var hasValidCredentials = SecurePassword.Verify(password, user.Password);

            if (! hasValidCredentials)
            {
                _logger.Warning($"Invalid credentials for username {user.UserName}");
            }
            else
            {
                _logger.Info($"Username {user.UserName} succesfully logged in");
            }

            return hasValidCredentials;
        }
    }
}
