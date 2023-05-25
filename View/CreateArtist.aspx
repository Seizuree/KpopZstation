<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainView.Master" AutoEventWireup="true" CodeBehind="CreateArtist.aspx.cs" Inherits="KpopZstation.View.InsertArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Artist</h1>
    <hr />
    <div>
        <asp:Label ID="lblArtName" runat="server" Text="Artist Name"></asp:Label>
        <asp:TextBox ID="tbArtName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblImage" runat="server" Text="Artist Image"></asp:Label>
        <asp:FileUpload ID="upImage" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label> 
    </div>
    <div>
        <asp:Button ID="btnSubmitArtist" runat="server" Text="Submit Artist" OnClick="btnSubmitArtist_Click" />
    </div>
</asp:Content>
