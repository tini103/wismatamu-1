<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="KelolaDataTransaksi.aspx.cs" Inherits="WismaTamu.KelolaDataTransaksi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pagetitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
    Kelola Data Transaksi
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    Pada halaman ini dapat melihat daftar transaksi yang akan dilakukan setiap pengguna atau setiap tanggal yang dilakukan serta menyetujui pesanan yang sudah dikonfirmasi. Nama pengguna bisa dicari menggunakan kode atau nama penggunanya.
    <div style="background-color:chocolate">
        <asp:Label ID="Label1" runat="server" Text="Label">Pencarian Pengguan&nbsp:&nbsp</asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="344px"></asp:TextBox>&nbsp&nbsp
        <asp:Button ID="Button1" runat="server" Text="Cari" OnClick="Button1_Click" />
        <p>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Untuk tangal Pemesanan :"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="tanggalPesan" runat="server" Width="191px"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server"  TargetControlID="tanggalPesan" Format="dd/MM/yyyy" />
        </p>
        <asp:PlaceHolder ID="listDataTransaksi" runat="server">
        <div id="popup">
            <div id="inner-popup">
               
                <asp:Repeater ID="rptTransaksi" ItemType="WismaTamu.Model.Pesanan" runat="server">
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td>
                                    <asp:Label ID="LabelIdentisasA" runat="server" Text="<%# Item.AnggotaPemesanId %>"></asp:Label>
                                    <asp:Label ID="LabelPesanan" runat="server" Text="<%# Item.IdPesanan %>"></asp:Label>
                                    <asp:Label ID="LabelCheckin" runat="server" Text="<%# Item.TanggalCheckin %>"></asp:Label>
                                    <asp:Label ID="LabelCheckOut" runat="server" Text="<%# Item.TanggalCheckout %>"></asp:Label>
                                    <asp:Label ID="LabelBiaya" runat="server" Text="<%# Item.BiayaPemesanan %>"></asp:Label>
                                </td>
                                <td>
                                    <asp:Button ID="Button2" runat="server" Text="Lihat Data Konfirmasi Pemesanan" />
                                    <asp:Button ID="Button3" runat="server" Text="Detil Pesanan" />
                                    <asp:Button ID="Button4" runat="server" Text="Hapus Pesanan Ini" />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </asp:PlaceHolder>
    </div>
</asp:Content>
