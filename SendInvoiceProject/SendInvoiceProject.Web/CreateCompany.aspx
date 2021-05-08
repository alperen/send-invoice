<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/LayoutWithAuthentication.master" AutoEventWireup="true" CodeBehind="CreateCompany.aspx.cs" Inherits="SendInvoiceProject.Web.Companies.CreateCompany" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">
        <label for="Content_displayName">Şirket İsmi</label>
        <asp:TextBox ID="DisplayName" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="Content_address">Addres</label>
        <asp:TextBox ID="Address" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="Content_taxId">Vergi Numarası</label>
        <asp:TextBox ID="TaxId" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="Content_taxId">Vergi Dairesi</label>
        <asp:TextBox ID="TaxOffice" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="Content_registeredNumber">Tescil Numarası</label>
        <asp:TextBox ID="RegisteredNumber" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
   
    <div class="mt-2">
         <asp:Button ID="createCompanyButton" runat="server" Text="Şirket Oluşturun" CssClass="btn btn-success" OnClick="createCompanyButton_Click" />
    </div>
</asp:Content>
