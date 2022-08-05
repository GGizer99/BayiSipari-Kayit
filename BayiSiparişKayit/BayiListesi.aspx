<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BayiListesi.aspx.cs" Inherits="BayiListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class ="table table-bordered table-hover">
        <tr>
            <th>Bayi Adı</th>
            <th>Bayi Adresi</th>
            <th>Bayi Telefon</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Bayi_ad")%></td>
                        <td><%#Eval("Bayi_adres")%></td>
                        <td><%#Eval("Bayi_tel")%></td>
                    </tr>
                   
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>

