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
    public partial class addRestaurant : System.Web.UI.Page
    {

        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetCategories";
                DataSet CategoryDS = objDB.GetDataSetUsingCmdObj(objCommand);
                ddlCategory.DataSource = CategoryDS;
                ddlCategory.DataBind();

            }
        }

        protected void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtRestaurantName.Text;
                String category = ddlCategory.SelectedValue;
                String image = txtImage.Text;
                String description = txtDescription.Text;

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "InsertRestaurant";

                SqlParameter inputParameter = new SqlParameter("@RestaurantName", name);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Category", category);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Image", image);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Description", description);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                objDB.DoUpdateUsingCmdObj(objCommand);

            }
            catch (Exception ex)
            {
                lblOutputMessage.Visible = true;
                lblOutputMessage.Text = "Error!";
            }

        }


    }
}
