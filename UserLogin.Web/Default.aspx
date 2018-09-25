<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserLogin.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Hej och välkommen <asp:LoginName ID="LoginName1" runat="server"/> !</h1>
        <p class="lead">Det här är min demo applikation</p>
        <asp:Button ID="Button1" OnClick="Logout_Click" Text="Logga ut"  runat="server" CssClass="btn btn-primary" />
    </div>
</asp:Content>
