<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainView.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="KpopZstation.View.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Artist Detail</h1>
    <div>
        <asp:Label ID="lblArtName" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblArtImage" runat="server" Text=""></asp:Label>
        <h3>List of Albums</h3>
    </div>
</asp:Content>
