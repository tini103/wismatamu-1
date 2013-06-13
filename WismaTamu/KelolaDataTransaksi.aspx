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
    <div>
        <br />
        Nomor identitas pengguna : <asp:TextBox ID="idMember" runat="server"></asp:TextBox> <br />
        <asp:Button ID="Button1" runat="server" Text="Lihat Transaksi" OnClick="Button1_Click"/>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            <div id="popup">
                <h4>Pesnaan kamar</h4>
                <div id="inner-popup" style="overflow: hidden">
                    <asp:Repeater ID="rpt" ItemType="WismaTamu.Model.Pesanan" runat="server" OnItemCommand="rpt_ItemCommand">
                        <ItemTemplate>
                            <div style="float: left;">
                            <%# Item.IdPesanan %> - <%# Item.AnggotaPemesan.NamaAnggota %> <br />
                                Pemesanan <%# Item.HitungJumlahKamarDipesan() %> kamar <br />
                                Tanggal Checkin: <%# Item.TanggalCheckin.ToString() %> <br />
                                Tanggal Checkout: <%# Item.TanggalCheckout.ToString() %> <br />
                                Biaya : Rp. <%# Item.BiayaPemesanan %>
                            </div>
                            <div style="float: right;">
                                
                                <asp:Button ID="Button3" runat="server" Text="Setujui Transaksi" CommandName="Setujui" CommandArgument="<%# Item.IdPesanan %>" visible="<%# Item.StatusPembayaran == 0 %>"/><br />
                                <asp:Button ID="Button4" runat="server" Text="Batalkan Transaksi" CommandName="Batalkan"  visible="<%# Item.StatusPembayaran == 0 %>"/><br />
                                <asp:Button ID="Button2" runat="server" Text="Lihat Konfirmasi Pembayaran" Command="LihatKonfirmasi" visible="<%# Item.StatusPembayaran == 0 %>"/>
                                <asp:Label ID="Label1" runat="server" Text="Pesanan ini masuk ruang tunggu!" Visible="<%# Item.StatusPembayaran == -1 %>"></asp:Label>
                                <asp:Label ID="Label2" runat="server" Text="Pesanan ini dibatalkan!" Visible="<%# Item.StatusPembayaran == -2 %>"></asp:Label>
                                <asp:Label ID="Label3" runat="server" Text="Pesanan ini telah disetujui!" Visible="<%# Item.StatusPembayaran == 1 %>"></asp:Label>
                            </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </asp:PlaceHolder>
    </div>
    
        

</asp:Content>
