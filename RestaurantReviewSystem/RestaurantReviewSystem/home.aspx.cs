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
    public partial class Home : System.Web.UI.Page
    {

        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objCommand.Parameters.Clear();

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetReviews";

                DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
                gvReviewDisplay.DataSource = myDS;
                gvReviewDisplay.DataBind();
            }

        }

        protected void btnFilterByCategory_Click(object sender, EventArgs e)
        {
            objCommand.Parameters.Clear();

            btnAddAnotherCategory.Visible = true;
            ddlCategory2.Visible = false;
            lblCategory2.Visible = false;
            lblAllReviews.Visible = false;
            lblCategory.Visible = true;
            ddlCategory.Visible = true;
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCategories";
            DataSet CategoryDS = objDB.GetDataSetUsingCmdObj(objCommand);
            ddlCategory.DataSource = CategoryDS;
            ddlCategory.DataBind();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCategoryDisplay";

            String category = ddlCategory.SelectedValue.ToString();

            SqlParameter inputParameter = new SqlParameter("@Category", category);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);


            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            gvReviewDisplay.DataSource = myDS;
            gvReviewDisplay.DataBind();
        }

        protected void btnAddAnotherCategory_Click(object sender, EventArgs e)
        {
            objCommand.Parameters.Clear();

            lblCategory2.Visible = true;
            ddlCategory2.Visible = true;
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCategories";
            DataSet CategoryDS = objDB.GetDataSetUsingCmdObj(objCommand);
            ddlCategory2.DataSource = CategoryDS;
            ddlCategory2.DataBind();

            

        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            ddlCategory.Visible = false;
            ddlCategory2.Visible = false;
            lblCategory.Visible = false;
            lblCategory2.Visible = false;
            lblAllReviews.Visible = true;

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetReviews";

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            gvReviewDisplay.DataSource = myDS;
            gvReviewDisplay.DataBind();
        }

        protected void UpdateGVCategory2(String category1, String category2)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCategoryDisplay2";

            SqlParameter inputParameter = new SqlParameter("@Category", category1);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Category2", category2);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            gvReviewDisplay.DataSource = myDS;
            gvReviewDisplay.DataBind();
        }

        protected void UpdateGVCategory(String category)
        {
            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCategoryDisplay";

            SqlParameter inputParameter = new SqlParameter("@Category", category);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);


            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            gvReviewDisplay.DataSource = myDS;
            gvReviewDisplay.DataBind();
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateGVCategory(ddlCategory.SelectedValue);
           
        }

        protected void ddlCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            objCommand.Parameters.Clear();
            UpdateGVCategory2(ddlCategory.SelectedValue, ddlCategory2.SelectedValue);
        }
    }
}
