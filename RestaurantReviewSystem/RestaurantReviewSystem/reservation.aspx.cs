using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

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

        protected void HideStuff()
        {
            lblRestaurant.Visible = false;
            ddlRestaurant.Visible = false;
            lblName.Visible = false;
            txtName.Visible = false;
            lblDate.Visible = false;
            txtDate.Visible = false;
            lblTime.Visible = false;
            txtTime.Visible = false;
            btnSubmit.Visible = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
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
                lblMessage.Visible = true;
                lblMessage.Text = "Your reservation has been added to the database.";
                HideStuff();
            }
            catch (Exception ex)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Could not add your reservation.";
            }

        }
        


    }
}
