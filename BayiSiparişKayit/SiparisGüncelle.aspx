<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SiparisGüncelle.aspx.cs" Inherits="SiparisGüncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

<form runat="server">


        <div>

            <asp:Label ID="Label3" runat="server" Text="Bayi Id (Şifreniz)"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" autocomplete="off" CssClass="form-control"></asp:TextBox>

        </div>

        <br />


        <div>

            <asp:Label ID="Label2" runat="server" Text="Sipariş Id"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" autocomplete="off" CssClass="form-control"></asp:TextBox>

        </div>

        <br />

        <div>

        <asp:Label ID="Label1" runat="server" Text="Güncellenecek Ürün"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>

        </div>
        
        <br />
         <asp:Button ID="Button1" runat="server" Text="Sipariş Güncelleme İşlemini Oluştur" CssClass="btn btn-success" OnClick="Button1_Click"/>
        
        


    </form>
    </asp:Content>

