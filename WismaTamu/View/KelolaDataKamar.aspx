<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="KelolaDataKamar.aspx.cs" Inherits="WismaTamu.View.KelolaDataKamar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pagetitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
    Kelola Data Kamar
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <p>
        Pada halaman ini, Anda dapat mengelola data kamar untuk masing-masing wisma.
    </p>
    <asp:Label ID="Label1" runat="server" Text="Pilih Wisma"></asp:Label>
    &nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="478px">
        <asp:ListItem>Wisma Yasmin</asp:ListItem>
        <asp:ListItem>Wisma Flamboyan</asp:ListItem>
        <asp:ListItem>Wisma Bougenvile</asp:ListItem>
    </asp:DropDownList>
    &nbsp;&nbsp; 
    <asp:Button ID="Button1" runat="server" Text="Cari" />
    <br />
    &nbsp;&nbsp;&nbsp;
    <br />
    <div style="background-color:#f5a562; height: 195px;">
        Kamar untuk Wisma 
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

        <br />

        <br />
        <asp:Repeater ID="Repeater1" runat="server">

        </asp:Repeater>
    </div>

</asp:Content>
