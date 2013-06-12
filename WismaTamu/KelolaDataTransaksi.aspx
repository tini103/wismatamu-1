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
        <input type="submit" value="Cari" />
        <p>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Untuk tangal Pemesanan :"></asp:Label>&nbsp&nbsp
            <asp:TextBox ID="tanggalPesan" runat="server" Width="191px"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server"  TargetControlID="TanggalCheckin" Format="dd/MM/yyyy" />
        </p>
        <asp:PlaceHolder ID="listDataTransaksi" runat="server">
        <div id="popup">
            Pada tanggal <asp:Label ID="lblTanggalAwal" runat="server" Text="Label "></asp:Label> hingga tanggal  <asp:Label ID="lblTanggalAkhir" runat="server" Text="Label"></asp:Label>
            <div id="inner-popup">
               
                <asp:Repeater ID="rptKamar" runat="server">
                    <ItemTemplate>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem Text="Kamar 1" Value="kamarId" />
                        </asp:CheckBoxList>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </asp:PlaceHolder>
    </div>
</asp:Content>
