using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1._1_Hur_många_versaler
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            outMessage.Text = String.Format("TextArea innehåller: {0} versaler", Model.TextAnalyzer.GetNumberOfCaptials(Input.Text));
            Input.Enabled = false;
            Button1.Visible = false;
            PlaceHolder1.Visible = true;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Input.Enabled = true;
            Button1.Visible = true;
            PlaceHolder1.Visible = false;
        }
    }
}