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
        Untuk tanggal : <asp:TextBox ID="tglPesanan" runat="server"></asp:TextBox><br />
        <ajaxToolkit:CalendarExtender TargetControlID="tglPesanan" runat="server" Format="dd/MM/yyyy"/>
        <asp:Button ID="Button1" runat="server" Text="Lihat Transaksi" OnClick="Button1_Click"/>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            <div id="popup">
                <h4>Pesnaan kamar</h4>
                <div id="inner-popup">
                    <asp:Repeater ID="rpt" ItemType="WismaTamu.Model.Pesanan" runat="server">
                        <ItemTemplate>
                            <%# Item.IdPesanan %> - <%# Item.AnggotaPemesan.NamaAnggota %> <br />
                            Pemesanan <%# Item.HitungJumlahKamarDipesan() %> <br />
                            Tanggal Checkin: <%# Item.TanggalCheckin.ToString() %> <br />
                            Tanggal Checkout: <%# Item.TanggalCheckout.ToString() %> <br />
                            Biaya : Rp. <%# Item.BiayaPemesanan %>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </asp:PlaceHolder>
    </div>
        

</asp:Content>
