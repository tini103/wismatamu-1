<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="ManageMember.aspx.cs" Inherits="WismaTamu.ManageMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pagetitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
    Kelola Member
    (Contoh Webforms) 
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <p>
        Id Memb er :
        <asp:TextBox ID="txtIdMember" runat="server" Width="229px"></asp:TextBox>
    </p>
    <p>
        Nama Member :
        <asp:TextBox ID="txtNamaMember" runat="server" Width="200px"></asp:TextBox>
    </p>
    <p>
        Alamat Member :
        <asp:TextBox ID="txtAlamatMember" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tambah Member" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" Width="509px">
        </asp:GridView>
    </p>
</asp:Content>
