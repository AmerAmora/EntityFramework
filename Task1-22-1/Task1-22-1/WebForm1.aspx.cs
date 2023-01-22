using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task1_22_1.Models;
namespace Task1_22_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Entities db = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                var x = from city in db.Cities select city;
                CityList.DataSource = x.ToList();
                CityList.DataTextField = "city_name";
                CityList.DataValueField = "city_id";
                CityList.DataBind();

            }
            var users = from Customer in db.Customers select Customer;
            
        }
        protected void AddUser(object sender, EventArgs e) 
        {
            string folderPath = Server.MapPath("~/Images/");

            Customer newCustomer = new Customer();
            newCustomer.customer_name = Name.Text;
            newCustomer.email = Email.Text;
            newCustomer.phone = Phone.Text;
            newCustomer.photo = "Images\\" + userImage.FileName;
            newCustomer.customer_age =Convert.ToInt32(Age.Text);
            newCustomer.city_id =Convert.ToInt32( CityList.SelectedValue);
            db.Customers.Add(newCustomer);
            db.SaveChanges();
            userImage.SaveAs(folderPath + Path.GetFileName(userImage.FileName));

        }

        
    }
}