﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
                lblUserGreeting.Text = "Hola, " + Session["Username"].ToString();
            else
                lblUserGreeting.Text = "Hola, Invitado";
        }
    }
}