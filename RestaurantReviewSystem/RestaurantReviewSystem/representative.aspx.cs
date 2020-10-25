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
    public partial class representative : System.Web.UI.Page
    {

        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
           
                
            
        }

        protected void btnAddRepresentative_Click(object sender, EventArgs e)
        {
            if (Session["userType"] == null)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "You have to login to add yourself!";
            }
            else if (Session["userType"].ToString() == "Representative")
            {
                ddlRestaurant.Visible = true;
                btnSubmit.Visible = true;
                lblMessage.Visible = true;
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetRestaurantNames";
                DataSet RestaurantDS = objDB.GetDataSetUsingCmdObj(objCommand);
                ddlRestaurant.DataSource = RestaurantDS;
                ddlRestaurant.DataBind();
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "You have to login to edit a review!";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String restaurant = ddlRestaurant.SelectedValue.ToString();
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "MakeRepresentative";
            objCommand.Parameters.AddWithValue("@RestaurantName", restaurant);
            objCommand.Parameters.AddWithValue("@Representative", Session["username"].ToString());

            objDB.DoUpdateUsingCmdObj(objCommand);
            lblMessage.Text = "You are now the representative of " + restaurant + ".";

        }


        protected void btnRemoveRepresentative_Click(object sender, EventArgs e)
        {
            if (Session["userType"] == null)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "You have to login to remove yourself!";
            }
            else if (Session["userType"].ToString() == "Representative")
            {
                lblMessage.Visible = true;
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "DeleteRepresentative";
                objCommand.Parameters.AddWithValue("@Name", Session["username"].ToString());
                objDB.DoUpdateUsingCmdObj(objCommand);
                lblMessage.Text = "You have been removed as representative.";
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "You have to login to edit a review!";
            }
        }

        protected void btnViewReservations_Click(object sender, EventArgs e)
        {
            lblReservations.Visible = true;
            lblReservations.Text = "Reservations For Your Restaurant:";

            if (Session["userType"] == null)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "You have to login to view your reservations!";
            }
            else if (Session["userType"].ToString() == "Representative")
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetReservations";
                objCommand.Parameters.AddWithValue("@Rep", Session["username"].ToString());
                objDB.DoUpdateUsingCmdObj(objCommand);
                DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
                gvReservations.DataSource = myDS;
                gvReservations.DataBind();

            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "You have to login to view your reservations!";
            }

        }
    }
}
