namespace UserLogin.Infrastructure.Migrations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UserLogin.Core;
    using UserLogin.Core.Model;

    public class Configuration : DbMigrationsConfiguration<UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UserContext context)
        {
            GetUsers().ForEach(c => context.Users.Add(c));
        }

        private static List<User> GetUsers()
        {
            var users = new List<User> {
                new User
                {
                    UserName = "karl",
                    Password = SecurePassword.Hash("sommar03")
                }
            };

            return users;
        }
    }
}


