<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="PendaftaranAnggota.aspx.cs" Inherits="WismaTamu.PendaftaranAnggota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pagetitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
    Pendaftaran Anggota Baru
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <asp:PlaceHolder ID="myPlace" runat="server">
    <p>
        Melalui halaman ini, Anda dapt mendaftarkan diri sebagai anggota baru Guesthouse ITS sehingga Anda bisa melakukan pemesanan kamar secara mandiri melalui sistem ini.
        <br/>
        Silakan masukan data diri Anda di sini.
    </p>
    <p style="color:red">
        *) Wajib diisi
    </p>
        <div style="background-color:aqua">
        <table style="background-color:aqua; border-color:aqua; vertical-align:top" border="1">
            <tr>
                <td colspan="2">
                    <h4><strong> Data autentikasi untuk masuk </strong></h4>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    Data berikut akan digunakan untuk proses masuk ke dalam sistem
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Width="250px"> <strong>No. Identitas Pengguna*</strong></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="tbIdentitas" Width="250px"/>
                    <asp:Label ID="Label11" runat="server" Text="&nbsp; &nbsp; &nbsp; &nbsp; No KTP/SIM/KTM ITS &nbsp; &nbsp;"/>
                    <asp:RequiredFieldValidator ControlToValidate="tbIdentitas" ErrorMessage="Harus Diisi" runat="server"/>
                </td>
            </tr>
            <tr>
                <td >
                    <asp:Label runat="server" Width="250px" ><strong>Alamat Surel*</strong></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbSurel" runat="server" placeholder="alamat@contoh.com" Width="250px" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="tbSurel" ErrorMessage="Harus Diisi" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="2"> Catatan: Anda dapat menggunakan nomor identitas / alamat surel untuk masuk </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Width="250px" ><strong>Kata Sandi*</strong></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbSandi" TextMode="Password" runat="server" Width="250px" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="tbSandi" ErrorMessage="Harus Diisi" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Width="250px"> <strong>Ulangi Kata Sandi*</strong></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbKonfSandi" TextMode="Password" runat="server" Width="250px" />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Kata Sandi Tidak Sama" ControlToCompare="tbSandi" ControlToValidate="tbKonfSandi"></asp:CompareValidator>
                </td>
            </tr>
            </table>
            </div>
        <div style="background-color:aqua">
        <table style="vertical-align:top;" >
            <tr>
                <td colspan="2"><h3><strong>Data diri pengguna</strong></h3></td>
            </tr>
            <tr>
                <td colspan="2">Silakan masukan data diri pengguna untuk mempermudah proses transaksi </td>
            </tr>
                    
            <tr>
                <td style="vertical-align:top;">
                    <asp:Label runat="server" Width="250px" ><strong>Nama Lengkap*</strong></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbNama" runat="server" placeholder="Nama Anda" Width="350px" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="tbNama" ErrorMessage="Harus Diisi" runat="server"/>
                </td>
            </tr>
            <tr>
                <td style="vertical-align:top;">
                    <asp:Label runat="server" Width="250px"><strong>Alamat/Domisili*</strong></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbAlamat" runat="server" placeholder="Alamat Anda" TextMode="MultiLine" Width="350px" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="tbAlamat" ErrorMessage="Harus Diisi" runat="server"/>
                </td>
            </tr>
            <tr>
                <td style="vertical-align:top;">
                    <asp:Label  runat="server" Width="250px"><strong>Nomor Kontak*</strong></asp:Label>
                </td>
                <td style="vertical-align:top;">
                    <asp:TextBox ID="tbKontak" runat="server" placeholder="Nomor Kontak Anda" TextMode="MultiLine" Width="250px" />
                    <asp:Label ID="Label12" runat="server" Text="&nbsp; &nbsp; &nbsp; &nbsp; HP/Telp yang bisa dihubungi" style="vertical-align:top;"/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="tbKontak" ErrorMessage="Harus Diisi" runat="server"/>
                </td>
            </tr>
    
            
        </table>
            </div>
        <div>
            <table>
            <tr>
                <td colspan="2"><asp:CheckBox ID="cbSetuju" runat="server" Text="Saya menyetujui segala ketentuan di dalam sistem manajemen pemesanan Guesthouse ITS ini" /></td>            
            </tr>
            <tr style="position:relative; margin:auto; left:0; right:0;">
                <td colspan="2">
                    <center><asp:Button ID="btnProses" runat="server" OnClick="btnProses_Click" Text="Proses Pendaftaran"/></center>
                </td>
            </tr>
                </table>
        </div>
    </asp:PlaceHolder>
</asp:Content>