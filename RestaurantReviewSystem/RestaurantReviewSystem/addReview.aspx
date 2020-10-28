<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addReview.aspx.cs" Inherits="RestaurantReviewSystem.addReview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

        <!-- Latest compiled and minified CSS -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
        <!-- jQuery library -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <!-- Popper JS -->
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
        <!-- Latest compiled JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script> 
        

    <title>Add Review</title>
</head>
<body>
    <form id="frmAddReview" runat="server">
        <div class=" container">
            <nav class="navbar navbar-expand-sm bg-light justify-content-center">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link" href="home.aspx">Reviews</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="restaurants.aspx">Restaurants</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="login.aspx">Login</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="addReview.aspx">Add Review</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="addRestaurant.aspx">Add Restaurant</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="reservation.aspx">Reservations</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="reviewer.aspx">Reviewer</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="representative.aspx">Representative</a>
                    </li>
                </ul>
            </nav>
        </div>

        <div class="container" style="text-align:center">
            <div class="jumbotron" style="align-content: center">
                <h1>Add A New Review</h1>
            </div>
        </div>

        <div class="container" >
            
            <div class="form-group" >
                <asp:Label ID="lblReviewer" runat="server" Text="Reviewer:"></asp:Label>
                <asp:DropDownList ID="ddlReviewer" runat="server" CssClass="form-control" Width="200px" DataTextField="Username"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label ID="lblRestaurant" runat="server" Text="Restaurant:"></asp:Label>
                <asp:DropDownList ID="ddlRestaurant" runat="server" CssClass="form-control " Width="200px" DataTextField="Restaurant_Name"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label ID="lblCategory" runat="server" Text="Category:">  </asp:Label>
                <asp:TextBox ID="txtCategory" runat="server" required="true" Width="200px"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblFoodRating" runat="server" Text="Food Rating:"></asp:Label>
                <asp:TextBox type="number" ID="txtFoodRating" runat="server" min="1" max="5" required="true" Width="50px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblServiceRating" runat="server" Text="Service Rating:"></asp:Label>
                <asp:TextBox type="number" ID="txtServiceRating" runat="server" min="1" max="5" required="true" Width="50px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblAtmosphereRating" runat="server" Text="Atmosphere Rating:"></asp:Label>
                <asp:TextBox type="number" ID="txtAtmosphereRating" runat="server" min="1" max="5" required="true" Width="50px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblPriceRating" runat="server" Text="Price Rating:"></asp:Label>
                <asp:TextBox type="number" ID="txtPriceRating" runat="server" min="1" max="5" required="true" Width="50px"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblComment" runat="server" Text="Comment:"></asp:Label>
                <asp:TextBox ID="txtComment" runat="server" Width="80%" Height="53px"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" CssClass="form-control" Width="400px" Text="Enter Review" OnClick="btnSubmit_Click" />
            </div>
            <div class="form-group">
                <div class="form-inline justify-content-center" >

                    <asp:Label ID="lblOutputMessage" runat="server" CssClass="form-control" Visible="False"></asp:Label>
                </div> 
           </div>


        </div>


    </form>
</body>
</html>
