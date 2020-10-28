<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addRestaurant.aspx.cs" Inherits="RestaurantReviewSystem.addRestaurant" %>

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
        
    <title>Add Restaurant</title>
</head>
<body>
    <form id="frmAddRestaurant" runat="server">
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
                <h1>Add A New Restaurant</h1>
            </div>
        </div>

        <div class="container">
            <div class="form-group">
                <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
                <asp:TextBox ID="txtRestaurantName" runat="server" required="true" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblCategory" runat="server" Text="Category:"></asp:Label>
                <asp:DropDownList ID="ddlCategory" runat="server" class="form-control" DataTextField="Category">
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label ID="lblImage" runat="server" Text="Image URL:"></asp:Label>
                <asp:TextBox ID="txtImage" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblDescription" runat="server" Text="Description:"></asp:Label>
                <asp:TextBox ID="txtDescription" runat="server" required="true" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="btnAddRestaurant" runat="server" CssClass="form-control" Width="400px" Text="Enter Restaurant" OnClick="btnAddRestaurant_Click" />
            <div class="form-group">
                <div class="form-inline justify-content-center" >
                    <asp:Label ID="lblOutputMessage" runat="server" Visible="False" CssClass="form-control"></asp:Label>
                </div>
            </div>
        </div>


    </form>
</body>
</html>
