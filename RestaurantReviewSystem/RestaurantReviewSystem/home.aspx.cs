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

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetReviews";

                DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
                gvReviewDisplay.DataSource = myDS;
                gvReviewDisplay.DataBind();
            }




        }

    }
}
