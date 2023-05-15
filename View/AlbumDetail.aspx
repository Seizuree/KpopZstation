<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainView.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="KpopZstation.View.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Styles/AlbumDetail.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Album Details</h1>
    <hr />
    <div>
        <div class="albumview">
            <asp:Label ID="AlbName" runat="server" Font-Bold="True" CssClass="albname"></asp:Label>
        </div>
        <div class="albumview">
            <asp:Label ID="lblAlbDesc" runat="server" Text="Description"></asp:Label>
            <asp:Label ID="AlbDesc" runat="server" CssClass="albdetail"></asp:Label>
        </div>
        <div class="albumview">
            <asp:Label ID="lblAlbPrice" runat="server" Text="Price"></asp:Label>
            <asp:Label ID="AlbPrice" runat="server" CssClass="albdetail"></asp:Label>
        </div>
        <div class="albumview">
            <asp:Label ID="lblAlbStock" runat="server" Text="Stock"></asp:Label>
            <asp:Label ID="AlbStock" runat="server" CssClass="albdetail"></asp:Label>
        </div>
        <div class="quantity albumview">
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
            <div>
                <asp:Button ID="btnRemove" runat="server" Text="-" OnClick="btnRemove_Click" Enabled="False" />
                <asp:TextBox ID="tbQuantity" runat="server" CssClass="quantitybox" Text="1"></asp:TextBox>
                <asp:Button ID="btnAdd" runat="server" Text="+" OnClick="btnAdd_Click" />
            </div>
            <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" OnClick="btnAddToCart_Click" />
        </div>
    </div>
</asp:Content>