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
                <br />
                <ajaxToolkit:CalendarExtender runat="server"  TargetControlID="tglCheckIn" Format="dd/MM/yyyy" />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="tglCheckIn" ErrorMessage="Masukkan tanggal dengan benar" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Tanggal check-out</strong></td>
            <td><asp:TextBox ID="tglCheckOut" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender runat="server"  TargetControlID="tglCheckOut" Format="dd/MM/yyyy" />
                <br />
                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="tglCheckOut" ErrorMessage="Masukkan tanggal dengan benar" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
            </td>
        </tr>
    </table>
   
    
    <asp:UpdatePanel ID="listKamarUpdatePanel" runat="server">
    <ContentTemplate>
    <p>
        <asp:Button ID="btnCariKamar" runat="server" Text="Cari Kamar" OnClick="btnCariKamar_Click"/>
        
    </p>
    <asp:Label ID="lblStatus" Visible="false" runat="server"></asp:Label>
    <asp:PlaceHolder ID="listKamarPlaceholder" runat="server">
        <div id="popup">
            <h4>Kamar yang tersedia</h4>
            Pada tanggal <asp:Label ID="lblTanggalAwal" runat="server" Text="Label "></asp:Label> hingga tanggal  <asp:Label ID="lblTanggalAkhir" runat="server" Text="Label"></asp:Label>
            <div id="inner-popup">
               
                <asp:Repeater ID="rptKamar" ItemType="WismaTamu.Model.Kamar" runat="server">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkKamarDipilih" runat="server" CssClass="hiddentext" Text="<%# Item.IdKamar %>" OnCheckedChanged="chkKamarDipilih_CheckedChanged"/>  <%# Item.GetNamaWisma() %> - <%# Item.NamaKamar %> - Kapasitas <%# Item.KapasitasKamar %> orang - Tarif : Rp. <%# Item.HargaPerMalam %> / Malam.
                        <asp:Button ID="btnLihatKamar" Text="Lihat Kamar" CommandName="doLihatKamar" runat="server"/><br />
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            Total Harga: <asp:Label ID="lblTotalHarga" runat="server" Text=""></asp:Label>
        </div>

    </asp:PlaceHolder>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
