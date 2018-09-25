<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UserLogin.Web.Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <webopt:bundlereference runat="server" path="~/Content/css" />
</head>
<body>
    <div class="login-form">
    <form id="form1" runat="server">
        <h2 class="text-center">Inloggning</h2>       
        <div class="form-group">
            <asp:TextBox ID="UserName" CssClass="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ForeColor="red" ID="UserNameRequiredFieldValidator" ControlToValidate="UserName" Display="Dynamic" ErrorMessage="Användarnamn är obligatoriskt!" runat="server" />
        </div>
        <div class="form-group">
            <asp:TextBox ID="Password" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ForeColor="red" ID="PasswordRequiredFieldValidator" ControlToValidate="Password" Display="Dynamic" ErrorMessage="Lösenord är obligatoriskt!" runat="server" />
        </div>
        <div class="form-group">
             <asp:Button ID="LogonButton" OnClick="Logon_Click" Text="Logga in"  CssClass="btn btn-primary btn-block" runat="server" />
        </div>
        <div class="clearfix">
            <label class="pull-left checkbox-inline"><input type="checkbox" runat="server" id="Persist"/>Kom ihåg</label>
        </div>  
         <p>
            <asp:Label ID="ErrorMessage" ForeColor="red" runat="server" />
        </p>
    </form>
   </div>
</body>
</html>
