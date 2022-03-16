<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dersler.aspx.cs" Inherits="Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form runat="server">
        <div>
            <strong>
                <asp:Label ID="Label1" runat="server" Text="Dersler:"></asp:Label>
            </strong>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <strong>
                <asp:Label for="TxtOgrID" runat="server" Text="Öğrenci ID:"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtOgrID" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Başvur" OnClick="Button1_Click" CssClass="btn btn-info" />
        </div>
    </form>
</asp:Content>

