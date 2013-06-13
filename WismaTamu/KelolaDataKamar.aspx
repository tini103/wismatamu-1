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
        <asp:ListItem Text="Wisma Yasmin"></asp:ListItem>
        <asp:ListItem Text="Wisma Flamboyan"></asp:ListItem>
        <asp:ListItem Text="Wisma Bougenvile"></asp:ListItem>
    </asp:DropDownList>
    &nbsp;&nbsp; 
    <asp:Button ID="Button1" runat="server" Text="Cari" OnClick="Button1_Click" />
    <br />
    &nbsp;&nbsp;&nbsp;
    <br />

    <asp:PlaceHolder ID="DetilKamarPlaceHolder" runat="server">
        <div id="popup">
            <h4>Kamar untuk 
            <asp:Label ID="txtWisma" runat="server" Text="<%# DropDownList1.SelectedValue %>"></asp:Label> <%# DropDownList1.SelectedValue %> </h4>
            <div id="inner-popup">
                <asp:Repeater ID="rptKamarWisma" ItemType="WismaTamu.Model.Kamar" runat="server">
                    <ItemTemplate>
                        <asp:Label ID="lblNama" runat="server" Text="<%# Item.NamaKamar %>"></asp:Label>
                        <asp:Label ID="lblJenis" runat="server" Text="<%# Item.JenisKamar %>"></asp:Label>
                        <asp:Label ID="lblKapasitas" runat="server" Text="<%# Item.KapasitasKamar %>"></asp:Label>
                        <asp:Label ID="lblHarga" runat="server" Text="<%# Item.HargaPerMalam %>"></asp:Label>--%>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </asp:PlaceHolder>
</asp:Content>
