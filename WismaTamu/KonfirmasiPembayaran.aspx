<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="KonfirmasiPembayaran.aspx.cs" Inherits="WismaTamu.KonfirmasiPembayaran" %>

<asp:Content ID="Content1" ContentPlaceHolderID="pagetitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
   Konfirmasi Pembayaran
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
     <strong>Langkah pertama</strong>: Pilih transaksi yang akan dikonfirmasi lalu klik "Konfirmasi pesanan ini".
    <div style="background-color:aliceblue">
        <h4>Transaksi Pemesanan Anda</h4>
        <p>
            <asp:PlaceHolder ID="listDataTransaksi" runat="server">
        <div id="popup">
            <div id="inner-popup">
               <%-- aku g tau repeaternya gmn --%>
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
                                    <asp:Button ID="Button2" runat="server" Text="KOnfirmasi Pesanan Ini" />
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
        </p>
    </div>
        
        
</asp:Content>
