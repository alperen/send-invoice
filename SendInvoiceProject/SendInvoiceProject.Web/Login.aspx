<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Layout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SendInvoiceProject.Web.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <div class="form-group">
        <label for="Content_EmailInput">E-posta adresiniz</label>
        <asp:TextBox ID="EmailInput" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group mt-2">
        <label for="Content_PasswordInput">Şifreniz</label>
        <asp:TextBox ID="PasswordInput" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="mt-2">
        <asp:Button ID="LoginButton" runat="server" Text="Giris Yap" OnClick="LoginButton_Click"  CssClass="btn btn-success" />
    </div>

    <div class="mt-2">
        <asp:UpdatePanel ID="updatePanel" runat="server">
            <ContentTemplate>
                <% if (!String.IsNullOrEmpty(alertMessage.Text)) { %>
                    <div class="alert alert-danger">
                        <asp:Label ID="alertMessage" runat="server"></asp:Label>
                    </div>
                <% } %>

                <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="LoginButton" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
    </div>
</asp:Content>
