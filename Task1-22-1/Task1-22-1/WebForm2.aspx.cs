using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task1_22_1.Models;

namespace Task1_22_1
{

    public partial class WebForm2 : System.Web.UI.Page
    {
        Entities db = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var s1 = (from b in db.Customers select b).Count();
            total.Text = s1.ToString();

            Customer custome = new Customer();

            var s2 = (from b in db.Customers select b.customer_age).Average();
            double avgAge = Convert.ToDouble(s2);
            avg.Text = avgAge.ToString();

            var s3 = (from b in db.Customers select b.customer_age).Max();
            max.Text = s3.ToString();

        }
    }
}