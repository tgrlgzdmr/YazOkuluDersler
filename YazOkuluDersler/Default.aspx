<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <strong>
                <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtNo" runat="server" Text="Öğrenci Numarası:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtNo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtMail" runat="server" Text="Öğrenci Mail:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtMail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifre"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="FupFoto" runat="server" Text="Öğrenci Fotoğraf:"></asp:Label>
                </strong>
                <asp:FileUpload ID="FupFoto" runat="server" />
            </div>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Öğrenci Ekle" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>
</asp:Content>

