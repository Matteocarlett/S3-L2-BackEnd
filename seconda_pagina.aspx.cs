using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class seconda_pagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Username"] != null)
            {
                lblUsername.Text = "Welcome, " + Request.Cookies["Username"].Value;
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["Username"] != null)
            {
                Response.Cookies["Username"].Expires = DateTime.Now.AddDays(-1);
                HttpCookie cookie = new HttpCookie("Username");
                Response.Cookies.Add(cookie);
            }
            Response.Redirect("Login.aspx");
        }
    }
}