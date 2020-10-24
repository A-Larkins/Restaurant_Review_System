<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reservation.aspx.cs" Inherits="RestaurantReviewSystem.reservation" %>

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
    
    <title>Reservation</title>
</head>
<body>
    <form id="frmReservation" runat="server">
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
                <h1>Reservations</h1>
            </div>
        </div>

        <div class="container">
            <div class="form-group">
                <asp:Label ID="lblRestaurant" runat="server" Text="Restaurant:"></asp:Label>
                <asp:DropDownList ID="ddlRestaurant" runat="server" CssClass="form-control" Width="200px" DataTextField="Restaurant_Name"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label ID="lblName" runat="server" Text="Your Name:"></asp:Label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblDate" runat="server" Text="Enter Date In The Form MM/DD/YYYY:"></asp:Label>
                <asp:TextBox ID="txtDate" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblTime" runat="server" Text="Enter Time In The Form 12:00PM:"></asp:Label>
                <asp:TextBox ID="txtTime" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" CssClass="form-control" Width="200px" Text="Submit" OnClick="btnSubmit_Click" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            </div>
        </div>




    </form>
</body>
</html>
