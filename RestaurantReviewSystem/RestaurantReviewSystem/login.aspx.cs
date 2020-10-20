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
    }
}


