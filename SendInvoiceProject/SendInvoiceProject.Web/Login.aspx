<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SendInvoiceProject.Web.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:Button ID="LoginButton" runat="server" Text="Giris Yap" OnClick="LoginButton_Click" />
    <asp:TextBox ID="EmailInput" runat="server"></asp:TextBox>
    <asp:TextBox ID="PasswordInput" runat="server"></asp:TextBox>
</asp:Content>
