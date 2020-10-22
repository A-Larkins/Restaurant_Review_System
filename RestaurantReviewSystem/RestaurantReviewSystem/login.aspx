<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="RestaurantReviewSystem.login" %>

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
        
    <title>Login</title>
</head>
<body>
    <form id="frmLogin" runat="server">
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
                <h1>Login</h1>
            </div>
        </div>

        <div class="container">
            <div class="form-inline justify-content-center" >
                <div class="form-group">
                    <asp:Label ID="lblLoginType" runat="server" Text="User Type: "></asp:Label>
                    &nbsp;<asp:DropDownList ID="ddlLoginType" runat="server" Width="200px">
                    <asp:ListItem Value="Reviewer">Reviewer</asp:ListItem>
                    <asp:ListItem Value="Representative">Representative</asp:ListItem>
                </asp:DropDownList>
                </div>
                <div class="form-group">
                    &nbsp;
                    <asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label>
                    &nbsp;<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    &nbsp;<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </div>
                <div class="form-group">
                    &nbsp;<asp:Label ID="lblUsernameMessage" runat="server" Visible="False"></asp:Label>
                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-5"></div>
        </div>

        <div class="container" style="text-align:center">
            <div class="jumbotron" style="align-content: center">
                <h1>..Or Create New Username</h1>
            </div>
        </div>

        <div class="container">
            <div class="form-inline justify-content-center">
                <div class="form-group">
                    <asp:Label ID="lblNewUserType" runat="server" Text="User Type: "></asp:Label>
                    &nbsp;<asp:DropDownList ID="ddlNewUserType" runat="server" Width="200px">
                    <asp:ListItem Value="Reviewer">Reviewer</asp:ListItem>
                    <asp:ListItem Value="Representative">Representative</asp:ListItem>
                </asp:DropDownList>
                </div>
                <div class="form-group">
                    &nbsp;
                    <asp:Label ID="lblNewUsername" runat="server" Text="Username: "></asp:Label>
                    &nbsp;<asp:TextBox ID="txtNewUsername" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    &nbsp;<asp:Button ID="btnNewUsername" runat="server" Text="Create" OnClick="btnNewUsername_Click" />
                </div>
                <div class="form-group">
                    &nbsp;<asp:Label ID="lblNewUsernameMessage" runat="server" Visible="False"></asp:Label>
                </div>
            </div>
        </div>
        


    </form>
</body>
</html>
