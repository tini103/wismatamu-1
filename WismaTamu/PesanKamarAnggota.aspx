<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="PesanKamarAnggota.aspx.cs" Inherits="WismaTamu.PesanKamarAnggota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pagetitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
    Pesan Kamar
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <p>
        Melalui halaman ini, Anda dapat melakukan pemesanan kamar secara langsung.</p>
    <p>
        <strong>Langkah pertama: </strong> Tentukan tanggal check-in dan check-out yang diinginkan, lalu klik tombol "Cari Kamar". Sistem akan menampilkan kamar yang tersedia pada tanggal tersebut.
    </p>
    <table>
        <tr>
            <td width="60%"><strong>Tanggal check-in</strong></td>
            <td >
                <asp:TextBox ID="tglCheckIn" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender runat="server"  TargetControlID="tglCheckIn" Format="dd/MM/yyyy" />
            </td>
        </tr>
        <tr>
            <td><strong>Tanggal check-out</strong></td>
            <td><asp:TextBox ID="tglCheckOut" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender runat="server"  TargetControlID="tglCheckOut" Format="dd/MM/yyyy" />
            </td>
        </tr>
    </table>
   
    
    <asp:UpdatePanel ID="listKamarUpdatePanel" runat="server">
    <ContentTemplate>
    <p>
        <asp:Button ID="btnCariKamar" runat="server" Text="Cari Kamar" OnClick="btnCariKamar_Click"/>
        
    </p>
    <asp:PlaceHolder ID="listKamarPlaceholder" runat="server">
        <div id="popup">
            <h4>Kamar yang tersedia</h4>
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
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
