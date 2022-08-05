<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SiparisTalebi.aspx.cs" Inherits="SiparisTalebi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form runat="server">

        <div>

        <asp:Label ID="Label1" runat="server" Text="Sipariş Edilecek Ürün"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>

        </div>
        <br />

        <div>

            <asp:Label ID="Label2" runat="server" Text="Bayi Id (Şifreniz)"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" autocomplete="off" CssClass="form-control"></asp:TextBox>

        </div>

        <br />
        
        <asp:Button ID="Button1" runat="server" Text="Sipariş Talebi Oluştur" CssClass="btn btn-warning" OnClick="Button1_Click" />
        


    </form>
    
</asp:Content>

