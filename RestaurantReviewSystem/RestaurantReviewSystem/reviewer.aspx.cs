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
    public partial class reviewer : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BindGV()
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetUserId";
            objCommand.Parameters.AddWithValue("@Username", Session["username"].ToString());

            SqlParameter outputName = new SqlParameter("@Id", 0);
            outputName.Direction = ParameterDirection.Output;
            objCommand.Parameters.Add(outputName);
            objDB.GetDataSetUsingCmdObj(objCommand);

            int reviewer_Id = int.Parse(objCommand.Parameters["@Id"].Value.ToString());
            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetReviews4Edit";
            objCommand.Parameters.AddWithValue("@Username", Session["username"].ToString());

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            gvEditReviews.DataSource = myDS;
            gvEditReviews.DataBind();
        }

        protected void btnEditReviews_Click(object sender, EventArgs e)
        {
            if (Session["userType"] == null)
            {
                lblMessage.Text = "You have to login to edit a review!";
            }
            else if (Session["userType"].ToString() == "Reviewer")
            {
                BindGV();
                lblMessage.Text = "";
            }
            else
            {
                lblMessage.Text = "You have to login to edit a review!";
            }
        }

        protected void gvEditReviews_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvEditReviews.EditIndex = -1;
            BindGV();
        }

        protected void gvEditReviews_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int id = int.Parse(gvEditReviews.Rows[rowIndex].Cells[0].Text);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "DeleteReview";
            objCommand.Parameters.AddWithValue("@Id", id);
            objDB.DoUpdateUsingCmdObj(objCommand);

            BindGV();
            lblMessage.Text = "Deleted review...";
        }

        protected void gvEditReviews_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvEditReviews.EditIndex = e.NewEditIndex;

            BindGV();
        }

        protected void gvEditReviews_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int id = int.Parse(gvEditReviews.Rows[rowIndex].Cells[0].Text);
            TextBox TBox;
            TBox = (TextBox)gvEditReviews.Rows[rowIndex].Cells[2].Controls[0];
            float foodRating = float.Parse(TBox.Text);
            TBox = (TextBox)gvEditReviews.Rows[rowIndex].Cells[3].Controls[0];
            float serviceRating = float.Parse(TBox.Text);
            TBox = (TextBox)gvEditReviews.Rows[rowIndex].Cells[4].Controls[0];
            float atmosRating = float.Parse(TBox.Text);
            TBox = (TextBox)gvEditReviews.Rows[rowIndex].Cells[5].Controls[0];
            float priceRating = float.Parse(TBox.Text);
            TBox = (TextBox)gvEditReviews.Rows[rowIndex].Cells[6].Controls[0];
            String comment = TBox.Text;

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateReview";
            objCommand.Parameters.AddWithValue("@Id", id);
            objCommand.Parameters.AddWithValue("@FoodRating", foodRating);
            objCommand.Parameters.AddWithValue("@ServiceRating", serviceRating);
            objCommand.Parameters.AddWithValue("@AtmosphereRating", atmosRating);
            objCommand.Parameters.AddWithValue("@PriceRating", priceRating);
            objCommand.Parameters.AddWithValue("@Comment", comment);
            objDB.DoUpdateUsingCmdObj(objCommand);


            gvEditReviews.EditIndex = -1;

            BindGV();
        }
    }
}