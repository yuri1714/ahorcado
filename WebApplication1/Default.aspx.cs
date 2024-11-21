using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMessage.Text = string.Empty;
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string validUser = "admin";
            string validPass = "12345";

            if (username == validUser && password == validPass)
            {
                LblMessage.Text = "Bienvenido " + username;
                Session["Username"] = username;
                
            }
            else
            {
                LblMessage.Text = "Usuario o contraseña incorrectos.";
            }
        }
    }
}