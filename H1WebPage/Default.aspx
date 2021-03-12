<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="H1WebPage.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pretty Website</title>

</head>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css"/>
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<body>
    <form runat="server" class="form">
    <div id="login">
        <h3 class="text-center text-white pt-5">Login form</h3>
        <div class="container">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6">
                    <div id="login-box" class="col-md-12">
                        <h3 runat="server" id="failText" class="text-center text-info"></h3>
                        <h3 class="text-center text-info">Login</h3>
                        <div class="form-group">
                            <label class="text-info">Username:</label><br/>
                            <input runat="server" type="text" name="username" id="username" class="form-control" required="required"/>
                        </div>
                        <div class="form-group">
                            <label class="text-info">Password:</label><br/>
                            <input runat="server" type="password" name="password" id="password" class="form-control" required="required"/>
                        </div>
                        <div class="form-group">
                            <label class="text-info"><span>Remember me</span> <span><input id="remember-me" name="remember-me" type="checkbox"/></span></label><br/>
                            <asp:button type="button" name="submit" class="btn btn-info btn-md" value="login" id="submit" runat="server" Text="Login" OnClick="submit_Click" CausesValidation="False" ></asp:button>
                        </div>
                        <div id="register-link" class="text-right">
                            <a href="Registre.aspx" class="text-info">Register here</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
