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
                <asp:Button ID="btCari" runat="server" Text="Cari" OnClick="btCari_Click" Width="81px" />
            </td>
        </tr>
    </table>
    <br/>
    <h4><strong> Daftar tamu yang checkin hari ini </strong></h4>
    <h5> <asp:Label ID="lblTanggal" runat="server" /> </h5>
    <!--<asp:GridView ID="grid" runat="server" BorderColor="Yellow">        
    </asp:GridView>-->
    <table>
    <asp:Repeater runat="server" ItemType="WismaTamu.Model.Pesanan" ID="repeater1">
        <ItemTemplate>            
                <tr>
                    <td>
                        <asp:Label ID="labelIdentitas" Text="<%# Item.IdAnggota %>" runat="server"/>
                        <asp:Label ID="labelDummy" Text=" - " runat="server"/>
                        <%
                            string text = "Pemesanan Item.Pesanan.Count kamar";
                        %>
                        <asp:Label ID="labelAnggota" Text="<%# Item.AnggotaPemesan.NamaAnggota %>" runat="server"/>
                        <br/>
                        <asp:Label ID="jumlahPesan" Text="<% text %>" runat="server" />
                        <br />
                        <%
                            text = "Tanggal Checkout: " + DateTime.Now.ToString();
                        %>
                        <asp:Label ID="labelCheckout" Text="<% text %>" runat="server" />
                    </td>
                    <td>
                        <asp:Button Text="Detail Pesanan" runat="server" ID="btnDetail" OnClick="btnDetail_Click"/>
                    </td>
                    <td>
                        <asp:Button Text="Checkin" runat="server" ID="btnCheckinDetail" OnClick="btnCheckinDetail_Click" CommandName="SegoGoreng"/>
                    </td>
                </tr>
            
        </ItemTemplate>
    </asp:Repeater>
     </table>
</asp:Content>