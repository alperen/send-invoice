<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Layout/LayoutWithAuthentication.master" AutoEventWireup="true" CodeBehind="Companies.aspx.cs" Inherits="SendInvoiceProject.Web.Compaines" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-between align-items-center">
        <h1>Şirketler</h1>
        <asp:Button ID="CreateACompanyButton" runat="server" Text="Bir Şirket Oluştur" CssClass="btn btn-success" OnClick="CreateACompanyButton_Click" />
    </div>

    <div>
        <asp:Repeater ID="CompaniesListRepeat" runat="server" OnItemCommand="CompaniesListRepeat_ItemCommand">
            <ItemTemplate>
                <div class="card mb-2">
                  <div class="card-body">
                      <h4><%# Eval("name") %></h4>
                      <hr />
                      <div>
                         <b> <%# Eval("taxId") %></b> / <%# Eval("taxOffice") %> -  <%# Eval("registeredNumber") %>
                      </div>
                      <hr />
                      <div>
                          <span>
                              <%# Eval("address") %>
                          </span>
                      </div>
                      <hr />
                      <div class="d-flex justify-content-end mt-2">
                          <asp:Button ID="CreateInvoiceButton" runat="server" Text="Fatura Oluştur" CssClass="btn btn-success me-2" />
                          <asp:Button ID="DeleteCompanyButton" runat="server" Text="Şirketi Sil" CssClass="btn btn-danger" CommandName="DeleteCompany" CommandArgument='<%# Eval("id") %>' OnClick="DeleteCompanyButton_Click" />
                      </div>
                  </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    </asp:Content>
