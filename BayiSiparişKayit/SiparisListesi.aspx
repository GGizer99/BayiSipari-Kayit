<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SiparisListesi.aspx.cs" Inherits="SiparisListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class ="table table-bordered table-hover">
        <tr>
            <th>Sipariş Id</th>
            <th>Ürün Adı</th>
            <th>Bayi Adı</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Siparis_id")%></td>
                        <td><%#Eval("S_urun_adi")%></td>
                        <td><%#Eval("S_bayi_adi")%></td>
                    </tr>
                    
                   
                </ItemTemplate>
                
            </asp:Repeater>
        </tbody>
    </table>   

    
        
   
    
</asp:Content>

