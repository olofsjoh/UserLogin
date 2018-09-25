using System;
using System.Web.Security;
using UserLogin.Core.Interfaces;
using UserLogin.Infrastructure.Factories;

namespace UserLogin.Web
{
    public partial class Login : System.Web.UI.Page
    {
        private IUserService _userService = UserFactory.Create();

        protected void Logon_Click(object sender, EventArgs e)
        {
            if (UserName.Text == string.Empty)
            {
                ErrorMessage.Text = "Användarnamn är obligatoriskt!";
                return;
            }

            if (Password.Text == string.Empty)
            {
                ErrorMessage.Text = "Lösenord är obligatoriskt!";
                return;
            }

            LoginUser();
        }

        private void LoginUser()
        {
            if (_userService.HasValidCredentials(UserName.Text, Password.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(UserName.Text, Persist.Checked);
            }
            else
            {
                ErrorMessage.Text = "Felaktigt användarnamn eller lösenord!";
            }
        }
    }
}