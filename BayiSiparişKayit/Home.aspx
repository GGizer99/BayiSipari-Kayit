<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

<form runat="server">
   <style>
.jumbotron {
  background-color: #f4511e; /* Orange */
  color: #ffffff;
}
</style>

<body>
  <div class="jumbotron text-center">
    <h1>STAJ YAPI MARKET</h1>
    
  </div>
</body>
    <div class="container-fluid text-center">
  <h2>SERVİSLER</h2>
  <h4></h4>
  <br>
  <div class="row">
    <div class="col-sm-4">
      <span class="glyphicon glyphicon-off"></span>
      <h4>BAYİLER</h4>
      <p>Bu ekranda kayıtlı bütün bayilerin bilgilerini görebilir dilerseniz telefon numaraları ile iletişim kurabilirsiniz.</p>
    </div>
    <div class="col-sm-4">
      <span class="glyphicon glyphicon-heart"></span>
      <h4>SİPARİŞ OLUŞTUR</h4>
      <p>Burada Ana Merkezimizden siparişlerinizi oluşturabilirsiniz.</p>
    </div>
    <div class="col-sm-4">
      <span class="glyphicon glyphicon-lock"></span>
      <h4>SİPARİŞ SİL</h4>
      <p>Burada oluşturduğunuz siparişlerinizi silebilirsiniz.</p>
    </div>
    </div>
    <br><br>
  <div class="row">
    <div class="col-sm-4">
      <span class="glyphicon glyphicon-leaf"></span>
      <h4>SİPARİŞ GÜNCELLE</h4>
      <p>Burada oluşturmuş olduğunuz siparişinizde ürün değişikliği yapabilirsiniz.</p>
    </div>
    <div class="col-sm-4">
      <span class="glyphicon glyphicon-certificate"></span>
      <h4>SİPARİŞLER</h4>
      <p>Burada diğer bayiler tarafındanda oluşturulmuş bütün sipariş kayıtlarını görebilirsiniz.</p>
    </div>
  </div>
</div>


</form>
</asp:Content>


