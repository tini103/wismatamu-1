<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Checkin.aspx.cs" Inherits="WismaTamu.Checkin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pagetitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
    Sugeng Rawuh
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <p>
        Untuk proses checkin, silakan masukan kode transaksi yang akan diproses kemudian tandai pemesanan yang akan ditandai sebagai checkin
    </p>
    <table>
        <tr>
            <td>
                Kode Transaksi
            </td>
            <td>
                <asp:TextBox runat="server" ID="tbCari" Width="357px" />
            </td>
            <td>
                <asp:Button ID="btCari" runat="server" Text="Cari" OnClick="btCari_Click" />
            </td>
        </tr>
    </table>
    <br/>
    <h4><strong> Daftar tamu yang checkin hari ini </strong></h4>
    <h5> <asp:Label ID="lblTanggal" runat="server" /> </h5>
    <asp:Repeater runat="server" ID="repeater1">
        <ItemTemplate>

        </ItemTemplate>
    </asp:Repeater>
</asp:Content>