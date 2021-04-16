<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="SendInvoiceProject.Web.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sign up</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="form-group">
        <label for="Content_email">E-posta adresiniz</label>
        <asp:TextBox ID="email" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group mt-2">
        <label for="Content_password">Parolaniz</label>
        <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group mt-2">
        <label for="Content_firstName">Adiniz</label>
        <asp:TextBox ID="firstName" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group mt-2">
        <label for="Content_firstName">Soyadiniz</label>
        <asp:TextBox ID="lastName" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="mt-2">
        <asp:Button ID="signupButton" runat="server" Text="Kayit Olun" CssClass="btn btn-success" OnClick="signupButton_Click" />
    </div>
</asp:Content>
