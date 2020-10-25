using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace RestaurantReviewSystem
{
    public partial class restaurants : System.Web.UI.Page
    {

        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetRestaurants";

                DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
                gvRestaurantDisplay.DataSource = myDS;
                gvRestaurantDisplay.DataBind();
            }


        }

        protected void btnFilterByCategory_Click(object sender, EventArgs e)
        {
            ddlCategory.Visible = true;
            lblAllRestaurants.Visible = false;
            objCommand.Parameters.Clear();
            
            lblAllRestaurants.Visible = false;
            lblCategory.Visible = true;
            ddlCategory.Visible = true;
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCategories";
            DataSet CategoryDS = objDB.GetDataSetUsingCmdObj(objCommand);
            ddlCategory.DataSource = CategoryDS;
            ddlCategory.DataBind();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCategoryDisplay4Restaurant";

            String category = ddlCategory.SelectedValue.ToString();

            SqlParameter inputParameter = new SqlParameter("@Category", category);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);


            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            gvRestaurantDisplay.DataSource = myDS;
            gvRestaurantDisplay.DataBind();
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            lblAllRestaurants.Visible = true;
            lblCategory.Visible = false;
            ddlCategory.Visible = false;
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetRestaurants";

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            gvRestaurantDisplay.DataSource = myDS;
            gvRestaurantDisplay.DataBind();

        }

        protected void UpdateGVCategory(String category)
        {
            objCommand.Parameters.Clear();
            lblAllRestaurants.Visible = false;
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetNewCategory4Restaurants";

            SqlParameter inputParameter = new SqlParameter("@Category", category);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);


            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            gvRestaurantDisplay.DataSource = myDS;
            gvRestaurantDisplay.DataBind();
        }


        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAllRestaurants.Visible = false;
            UpdateGVCategory(ddlCategory.SelectedValue);

        }
    }
}

