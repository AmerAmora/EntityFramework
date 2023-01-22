using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task1_22_1.Models;

namespace Task1_22_1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Entities db = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var query = from t1 in db.Cities
                        join t2 in db.Customers
                        on t1.city_id equals t2.city_id
                        select new { t2.customer_id, t2.customer_name, t2.customer_age, t2.email, t2.phone, t2.photo, t1.city_name };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            var stringNumber = TextBox1.Text;
            int numericValue;
            bool isNumber = int.TryParse(stringNumber, out numericValue);
            if (!isNumber)
            {
                
                var search = from t1 in db.Cities
                             join t2 in db.Customers
                             on t1.city_id equals t2.city_id
                             where t2.customer_name.Contains(TextBox1.Text)
                             select new { t2.customer_id, t2.customer_name, t2.customer_age, t2.email, t2.phone, t2.photo, t1.city_name };
                GridView1.DataSource = search.ToList();
                GridView1.DataBind();
            }
            else
            {
                var search = from t1 in db.Cities
                             join t2 in db.Customers
                             on t1.city_id equals t2.city_id
                             where t2.customer_id == numericValue
                             select new { t2.customer_id, t2.customer_name, t2.customer_age, t2.email, t2.phone, t2.photo, t1.city_name };
                GridView1.DataSource = search.ToList();
                GridView1.DataBind();

            }

        }
    }
}