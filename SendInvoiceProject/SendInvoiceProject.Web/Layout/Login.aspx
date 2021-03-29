<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SendInvoiceProject.Web.Layout.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <header>
                <nav class="navbar navbar-expand-lg navbar-light bg-light">
                    <div class="container-fluid">
                        <a class="navbar-brand" href="#">Send Invoice</a>

                         <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                            <li class="nav-item">
                              <a class="nav-link" href="#">Giris Yap</a>
                            </li>
                            <li class="nav-item">
                              <a class="nav-link" href="#">Fatura Kes</a>
                            </li>
                            <li class="nav-item">
                              <a class="nav-link" href="#">Fatura Görüntüle</a>
                            </li>
                            <li class="nav-item">
                              <a class="nav-link" href="#">Ürün Yönetimi</a>
                            </li>
                            <li class="nav-item">
                              <a class="nav-link" href="#">Müşteri Yönetimi</a>
                            </li>
                         </ul>
                     </div>
                </nav>
            </header>

            <div class="row mt-3">
                <div class="col col-sm-3">
                    <ul class="list-group">
                      <li class="list-group-item">Sub menu item 1</li>
                      <li class="list-group-item">Sub menu item 2</li>
                      <li class="list-group-item">Sub menu item 3</li>
                    </ul>
                </div>
                <div class="col col-sm-9">
                    <main>
                        <div class="mb-3">
                            <label for="email" class="form-label">E-posta Adresi</label>
                            <input type="email" id="email" class="form-control" />
                        </div>
                        <div class="mb-3">
                          <label for="password" class="form-label">Şifre</label>
                          <input type="password" id="email" class="form-control" />
                        </div>
                        <button type="submit" class="btn btn-primary">Giriş Yap</button>
                    </main>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
