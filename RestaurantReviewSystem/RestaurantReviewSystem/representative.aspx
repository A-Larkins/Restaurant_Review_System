﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="representative.aspx.cs" Inherits="RestaurantReviewSystem.representative" %>

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
    
    <title>Representative</title>
</head>
<body>
    <form id="frmRepresentative" runat="server">
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
                <h1>Add Representative</h1>
            </div>
        </div>

        <div class="container">
            <div class ="form-group">
                <div class="d-flex justify-content-center">
                    <asp:Button ID="btnAddRepresentative" runat="server" CssClass="form-control" Width="400px"  Text="Add yourself to a restaurant." OnClick="btnAddRepresentative_Click" />
                </div>
            </div>
            
            <div class ="form-group">
                <div class="d-flex justify-content-center">
                    <asp:DropDownList ID="ddlRestaurant" runat="server" CssClass="form-control" Width="200px" DataTextField="Restaurant_Name" Visible="False"></asp:DropDownList>

                </div>
            </div>        
            <div class ="form-group">
                <div class="d-flex justify-content-center">
                    <asp:Button ID="btnSubmit" runat="server" CssClass="form-control" Width="100px" Text="Submit" Visible="False" OnClick="btnSubmit_Click" />
                </div>
            </div> 
            <div class ="form-group">
                <div class="d-flex justify-content-center">
                    <asp:Button ID="btnDeleteRepresentative" runat="server" CssClass="form-control" Width="400px" Text="Remove yourself from a restaurant." OnClick="btnRemoveRepresentative_Click" />
                </div>
            </div>

            <div class ="form-group">
                <div class="d-flex justify-content-center">
                    <asp:Label ID="lblMessage" runat="server" Visible="False"></asp:Label>
                </div>
            </div>
        </div>


    </form>
</body>
</html>
