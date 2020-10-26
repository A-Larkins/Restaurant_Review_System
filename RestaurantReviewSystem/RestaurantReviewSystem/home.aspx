<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="RestaurantReviewSystem.Home" %>

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
    
    <title>Reviews</title>
</head>
<body>
    <form id="frmHome" runat="server" aria-pressed="false" >
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
                <h1>Reviews</h1>
            </div>
        </div>

        <div class="container">
            <div class="form-inline justify-content-center" >
                <div class="form-group">
                    <asp:Button ID="btnFilterByCategory" runat="server" CssClass="form-control" Width="300px" Text="Filter By Category" OnClick="btnFilterByCategory_Click" />
                </div>
               <div class="form-group">
                    &nbsp;&nbsp;<asp:Button ID="btnAddAnotherCategory" runat="server" CssClass="form-control" Width="300px" Text="Add another Category" OnClick="btnAddAnotherCategory_Click" Visible="False" />
                </div>
                <div class="form-group">
                    &nbsp;&nbsp;<asp:Button ID="btnDisplayAll" runat="server" CssClass="form-control" Width="300px" Text="Display All" OnClick="btnDisplayAll_Click"  />
                </div>
                <div class="form-group">
                    &nbsp;&nbsp;<asp:Button ID="btnDisplayRestaurantAverages" runat="server" CssClass="form-control" Width="300px" Text="Display Restaurant Averages" OnClick="btnDisplayRestaurantAverages_Click"   />
                </div>
            </div>
            <div class="form-group"></div>
        </div>

        <div class="container">
            <div class="form-inline justify-content-center" >
                <div class="form-group">
                    <asp:Label ID="lblCategory" runat="server" Text="Category:" Visible="False"></asp:Label>
                    &nbsp;&nbsp;<asp:DropDownList ID="ddlCategory" AutoPostBack="True" runat="server" class="form-control" DataTextField="Category" Visible="False" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    &nbsp;&nbsp;<asp:Label ID="lblCategory2" runat="server" Text="Category:" Visible="False"></asp:Label>
                    &nbsp;&nbsp;<asp:DropDownList ID="ddlCategory2" AutoPostBack="True" runat="server" class="form-control" DataTextField="Category" Visible="False" OnSelectedIndexChanged="ddlCategory2_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
               
            </div>
        </div>


        <p></p>


         <div class="container" >
            <div class="d-flex justify-content-center">
                <asp:Label ID="lblAllReviews" runat="server" Text="">
                    <h3>All Reviews</h3>
                </asp:Label>
            </div>
        </div>

        <asp:GridView ID="gvReviewDisplay"  AutoPostBack="True" runat="server" CssClass ="table table-striped table-bordered" style="width:90%; margin:auto;" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Reviewer_Name" HeaderText="Reviewer" />
                <asp:BoundField DataField="Restaurant_Name" HeaderText="Restaurant" />
                <asp:BoundField DataField="Food_Rating" HeaderText="Food Rating" />
                <asp:BoundField DataField="Service_Rating" HeaderText="Service Rating" />
                <asp:BoundField DataField="Atmosphere_Rating" HeaderText="Atmosphere Rating" />
                <asp:BoundField DataField="Price_Rating" HeaderText="Price Rating" />
                <asp:BoundField DataField="Comment" HeaderText="Comment" />
            </Columns>

        </asp:GridView>

        <asp:GridView ID="gvRestaurantAverages"  AutoPostBack="True" runat="server" CssClass ="table table-striped table-bordered" style="width:90%; margin:auto;" AutoGenerateColumns="False" Visible="False">
            <Columns>
                <asp:BoundField DataField="Restaurant_Name" HeaderText="Restaurant" />
                <asp:BoundField DataField="Food_Rating" HeaderText="Food Rating" DataFormatString="{0:0.00}" />
                <asp:BoundField DataField="Service_Rating" HeaderText="Service Rating" DataFormatString="{0:0.00}" />
                <asp:BoundField DataField="Atmosphere_Rating" HeaderText="Atmosphere Rating" DataFormatString="{0:0.00}" />
                <asp:BoundField DataField="Price_Rating" HeaderText="Price Rating" DataFormatString="{0:0.00}" />
            </Columns>

        </asp:GridView>

        <br /><br /><br />


    </form>
</body>
</html>
