<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainView.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KpopZstation.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="gvArtistsDetail" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvArtistsDetail_RowDeleting" OnRowEditing="gvArtistsDetail_RowEditing">
            <Columns>
                <asp:BoundField DataField="ArtistID" HeaderText="ID" SortExpression="ArtistID"></asp:BoundField>
                <asp:BoundField DataField="Artistname" HeaderText="Artist Name" SortExpression="ArtistName"></asp:BoundField>                
                <asp:ImageField DataImageUrlField="ArtistImage" HeaderText="Artist Image" ControlStyle-Height="150" ControlStyle-Width="150">
<ControlStyle Height="150px" Width="150px"></ControlStyle>
                </asp:ImageField>
                <asp:CommandField ButtonType="Button" ShowCancelButton="False" ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" HeaderText="" ButtonType="Button"></asp:CommandField>
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Button ID="btnInsertArtist" runat="server" Text="Insert Artist" OnClick="btnInsertArtist_Click" />
    </div>
</asp:Content>
