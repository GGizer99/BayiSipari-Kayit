<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SiparisSil.aspx.cs" Inherits="SiparisSil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    
    <form runat="server">

        <div>


            <asp:Label ID="Label1" runat="server" Text="Bayi Id (Şifreniz)"></asp:Label>

            <asp:TextBox ID="TextBox2" runat="server" autocomplete="off" CssClass="form-control"></asp:TextBox>
           

        </div>

         <br />

        <div>

            <asp:Label ID="Label2" runat="server" Text="Sipariş Id"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" autocomplete="off" CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Sil" CssClass="btn btn-danger" OnClick="Button1_Click" />



    </form>
   

</asp:Content>