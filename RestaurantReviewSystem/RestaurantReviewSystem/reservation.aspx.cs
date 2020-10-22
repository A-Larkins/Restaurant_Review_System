using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantReviewSystem
{
    public partial class reservation : System.Web.UI.Page
    {

        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetRestaurantNames";
                DataSet RestaurantDS = objDB.GetDataSetUsingCmdObj(objCommand);
                ddlRestaurant.DataSource = RestaurantDS;
                ddlRestaurant.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String restaurant = ddlRestaurant.SelectedValue.ToString();
            String name = txtName.Text;
            String date = txtDate.Text;
            String time = txtTime.Text;

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "MakeReservation";
            objCommand.Parameters.AddWithValue("@RestaurantName", restaurant);
            objCommand.Parameters.AddWithValue("@Name", name);
            objCommand.Parameters.AddWithValue("@Date", date);
            objCommand.Parameters.AddWithValue("@Time", time);

            objDB.DoUpdateUsingCmdObj(objCommand);
            lblMessage.Text = "Your reservation has been added to the database.";


        }



    }
}