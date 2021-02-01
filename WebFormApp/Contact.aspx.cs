using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormApp
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = string.Format("Hello, {0}. You said you are {1}? What an enlightening age. May we contact you back at this email address: '{2}'? We guess your favorite color is {3}",
                txtName.Text, txtAge.Text, txtEmail.Text, ddlColor.SelectedValue);
            ltMessage.Text = message;
        }
    }
}