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
    public partial class addReview : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetReviewers";
                DataSet ReviewersDS = objDB.GetDataSetUsingCmdObj(objCommand);
                ddlReviewer.DataSource = ReviewersDS;
                ddlReviewer.DataBind();

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "GetRestaurantNames";
                DataSet RestaurantDS = objDB.GetDataSetUsingCmdObj(objCommand);
                ddlRestaurant.DataSource = RestaurantDS;
                ddlRestaurant.DataBind();
                

            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                String reviewer = ddlReviewer.SelectedValue;
                String restaurant = ddlRestaurant.SelectedValue;
                String category = txtCategory.Text;

                float foodRating = int.Parse(txtFoodRating.Text);
                float serviceRating = int.Parse(txtServiceRating.Text);
                float atmosphereRating = int.Parse(txtAtmosphereRating.Text);
                float priceRating = int.Parse(txtPriceRating.Text);
                String comment = txtComment.Text;

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "InsertReview";

                SqlParameter inputParameter = new SqlParameter("@Reviewer_Name", reviewer);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Restaurant_Name", restaurant);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Category", category);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.NChar;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Food_Rating", foodRating);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.Float;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Service_Rating", serviceRating);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.Float;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Atmosphere_Rating", atmosphereRating);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.Float;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Price_Rating", priceRating);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.Float;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Comment", comment);
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