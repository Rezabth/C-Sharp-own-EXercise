using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multiplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            int val1, val2;
            val1 = Convert.ToInt32(txtVal1.Text);
            val2 = Convert.ToInt32(txtVal2.Text);
            int result = val1 * val2;
            Label1.Text = result.ToString();


        }
    }
}