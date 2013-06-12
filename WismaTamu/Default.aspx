<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WismaTamu.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pagetitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
    Selamat Datang
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <p>
        Halaman ini merupakan sistem manajemen pemesanan kamar (Booking Management System) dari Guesthouse ITS.
        Melalui halaman ini, pengguna umum bisa melakukan pemesanan terhadap kamar dari tiga wisma (Wisma Flamboyan, Wisma Bougenville, dan Wisma Yasmin)
        dan melakukan konfirmasi pembayaran pemesanan secara mandiri.
    </p>
    <p>
        Untuk memulai pemesanan, pengguna diwajibkan memiliki akun yang bisa didaftarkan secara mandiri melalui <a href="~/DaftarAnggota.aspx">tautan ini</a>. 
        Setelah pendaftaran dilakukan, proses pemesanan bisa dilakukan melalui menu "Cari dan Pesan Kamar" serta dilanjutkan dengan konfirmasi 
        pembayaran pemesanan melalui menu "Konfirmasi Pemesanan". Untuk setiap pemesanan yang jadi, pengguna akan mendapatkan semacam nota yang digunakan untuk proses checkin maupun checkout.
    </p>
    <div id="info">
        <h1>Butuh bantuan?</h1>
        <p>Silahkan hubungi (031) 596 1215.</p>
    </div>
</asp:Content>
