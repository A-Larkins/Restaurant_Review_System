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
    }
}

