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
    public partial class login : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNewUsername_Click(object sender, EventArgs e)
        {
            try
            {
                String newUserType = ddlNewUserType.SelectedValue;
                String newUserName = txtNewUsername.Text;

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "InsertUser";

                SqlParameter inputParameter = new SqlParameter("@Username", newUserName);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Type", newUserType);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                objDB.DoUpdateUsingCmdObj(objCommand);

                lblNewUsernameMessage.Visible = true;
                lblNewUsernameMessage.Text = "A new user has been added as type " + newUserType;

            }
            catch (Exception ex)
            {
                lblNewUsernameMessage.Visible = true;
                lblNewUsernameMessage.Text = "Error!";
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String userType = ddlLoginType.SelectedValue;
            String username = txtUsername.Text;
            Session.Add("userType", "");
            Session.Add("username", "");

            if (userType == "Reviewer")
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetReviewerUserName";
                SqlParameter inputParameter = new SqlParameter("@Username", username);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                DataSet objDS = objDB.GetDataSetUsingCmdObj(objCommand);

                if (objDS == null || objDS.Tables.Count == 0 || objDS.Tables[0].Rows.Count == 0)
                {
                    lblUsernameMessage.Visible = true;
                    lblUsernameMessage.Text = "Username is not in database.";
                }
                else
                {
                    Session["username"] = txtUsername.Text;
                    Session["userType"] = ddlLoginType.SelectedValue;
                    //Session["username"] = objDS.Tables[0].Rows[0][0].ToString();
                    //Session["userType"] = objDS.Tables[0].Rows[0][1].ToString();
                    lblUsernameMessage.Visible = true;
                    lblUsernameMessage.Text = "Logged in as " + objDS.Tables[0].Rows[0][0].ToString();                }
                
                }
            else if (userType == "Representative")
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetRepresentativeUserName";
                SqlParameter inputParameter = new SqlParameter("@Username", username);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);
                DataSet objDS = objDB.GetDataSetUsingCmdObj(objCommand);

                if (objDS == null || objDS.Tables.Count == 0 || objDS.Tables[0].Rows.Count == 0)
                {
                    lblUsernameMessage.Visible = true;
                    lblUsernameMessage.Text = "Username is not in database.";
                }
                else
                {
                    Session["username"] = objDS.Tables[0].Rows[0][0].ToString();
                    Session["userType"] = objDS.Tables[0].Rows[0][1].ToString();
                    lblUsernameMessage.Visible = true;
                    lblUsernameMessage.Text = "Logged in as " + objDS.Tables[0].Rows[0][0].ToString();
                }

                
            }
            // put text box back to blank after  login
            txtUsername.Text = "";

        }

    }
}


