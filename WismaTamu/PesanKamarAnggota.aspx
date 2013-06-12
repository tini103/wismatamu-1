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
    <asp:UpdatePanel ID="listKamarUpdatePanel" runat="server">
    <ContentTemplate>
    <asp:PlaceHolder ID="pilihTanggalPlaceholder" runat="server">
    <table>
        <tr>
            <td width="60%"><strong>Tanggal check-in</strong></td>
            <td >
                <asp:TextBox ID="tglCheckIn" runat="server" OnTextChanged="tglCheckIn_TextChanged"></asp:TextBox>
                <br />
                <ajaxToolkit:CalendarExtender runat="server"  TargetControlID="tglCheckIn" Format="dd/MM/yyyy" />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="tglCheckIn" ErrorMessage="Masukkan tanggal dengan benar" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td><strong>Tanggal check-out</strong></td>
            <td><asp:TextBox ID="tglCheckOut" runat="server" OnTextChanged="tglCheckOut_TextChanged"></asp:TextBox>
                <ajaxToolkit:CalendarExtender runat="server"  TargetControlID="tglCheckOut" Format="dd/MM/yyyy" />
                <br />
                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="tglCheckOut" ErrorMessage="Masukkan tanggal dengan benar" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
            </td>
        </tr>
    </table>
   </asp:PlaceHolder>
    
    
    <p>
        <asp:Button ID="btnCariKamar" runat="server" Text="Cari Kamar" OnClick="btnCariKamar_Click"/>
        
    </p>
    <asp:Label ID="lblStatus" Visible="false" runat="server"></asp:Label>
    <asp:PlaceHolder ID="listKamarPlaceholder" runat="server">
        <p>
            <strong>Langkah Kedua: </strong> Beri tanda centang pada kamar yang ingin dipesan pada kotak dibawah ini. Kemudian klik tombol "Proses Pesanan" untuk menyetujui Pesanan.
        </p>
        <div id="popup">
            <h4>Kamar yang tersedia</h4>
            Pada tanggal <asp:Label ID="lblTanggalAwal" runat="server" Text="Label "></asp:Label> hingga tanggal  <asp:Label ID="lblTanggalAkhir" runat="server" Text="Label"></asp:Label>
            <div id="inner-popup">
               
                <asp:Repeater ID="rptKamar" ItemType="WismaTamu.Model.Kamar" runat="server" OnItemCreated="rptKamar_ItemCreated">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkKamarDipilih" AutoPostBack="true" runat="server" CssClass="hiddentext" Text="<%# Item.IdKamar %>" OnCheckedChanged="chkKamarDipilih_CheckedChanged"/>  <%# Item.GetNamaWisma() %> - <%# Item.NamaKamar %> - Kapasitas <%# Item.KapasitasKamar %> orang - Tarif : Rp. <asp:Label ID="lblHargaPerItem" Text="<%# Item.HargaPerMalam %>"  runat="server"/> / Malam.
                        <asp:Button ID="btnLihatKamar" Text="Lihat Kamar" CommandName="doLihatKamar" runat="server"/><br />
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            Total Harga: <asp:Label ID="lblTotalHarga" runat="server" Text=""></asp:Label>
        </div>

    </asp:PlaceHolder>
    <asp:PlaceHolder ID="setujuPesananPlaceholder" runat="server">
    <p>Dengan melakukan pemesanan kamar pada Guesthouse ITS, Anda menyetujui segala ketentuan umum dalam proses pemesanan daring ini.</p>
    <asp:Button ID="btnPesan" runat="server" Text="Proses Pemesanan" OnClick="btnPesan_Click" />
    </asp:PlaceHolder>
    <asp:PlaceHolder ID="hasilPesanan" runat="server" Visible="false">
        <p><strong>Selamat! Proses pemesanan telah sukses dilakukan dengan detail : </strong></p>
        <table>
            <tr>
                <td><strong>Nomor Pesanan</strong></td>
                <td><asp:Label ID="nmrPesanan" runat="server" Text="Nomor Pemesan"></asp:Label></td>
            </tr>
            <tr>
                <td><strong>Nama Pemesan</strong></td>
                <td><asp:Label ID="namaPemesan" runat="server" Text="Nomor Pemesan"></asp:Label></td>
            </tr>
            <tr>
                <td><strong>Alamat Pemesan</strong></td>
                <td><asp:Label ID="alamatPemesan" runat="server" Text="Nomor Pemesan"></asp:Label></td>
            </tr>
            <tr>
                <td><strong>Kamar Dipesan</strong></td>
                <td><asp:BulletedList ID="kamarYangDipesan" runat="server"></asp:BulletedList></td>
            </tr>
        </table>
        <p>Silahkan untuk selanjutnya melakukan pembayaran pemesanan melalui rekening <strong>Bank BNI ITS atas nama REKTOR ITS nomor rekening 0049842577</strong>. Kemudian lakukan proses
            konfirmasi pembayaran (scan bukti pembayaran) melalui daring dengan fitur konfirmasi pemesanan atau fax secara luring melalui nomor (031) 596 1215.
        </p>
        <p>Terima kasih.</p>
    </asp:PlaceHolder>
    </ContentTemplate>
    
    </asp:UpdatePanel>
</asp:Content>
