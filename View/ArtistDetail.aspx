<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainView.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="KpopZstation.View.ArtistDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Artist Detail</h1>
    <div>
        <asp:Image ID="imgArt" runat="server" Height="200px" Width="200px" />
        <br />
        <asp:Label ID="lblArtName" runat="server" Text=""></asp:Label>
        <h3>List of Albums</h3>
    </div>
    <div>
        <asp:GridView ID="gvAlbumsDetail" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvAlbumsDetail_RowDeleting" OnRowEditing="gvAlbumsDetail_RowEditing">
            <Columns>
                <asp:BoundField DataField="AlbumID" HeaderText="ID" SortExpression="AlbumID"></asp:BoundField>
                <asp:BoundField DataField="Albumname" HeaderText="Album Name" SortExpression="AlbumName"></asp:BoundField>
                <asp:BoundField DataField="AlbumPrice" HeaderText="Album Price" SortExpression="AlbumPrice"></asp:BoundField>
                <asp:BoundField DataField="AlbumDescription" HeaderText="Album Description" SortExpression="AlbumDescription"></asp:BoundField>
                <asp:ImageField DataImageUrlField="AlbumImage" HeaderText="Album Image" ControlStyle-Height="150" ControlStyle-Width="150">
<ControlStyle Height="150px" Width="150px"></ControlStyle>
                </asp:ImageField>
                
                <asp:CommandField ButtonType="Button" EditText="Update" ShowCancelButton="False" ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" HeaderText="" ButtonType="Button"></asp:CommandField>
            </Columns>
        </asp:GridView>
        <br />
    </div>
    <br />
    <div>
        <asp:Button ID="btnInsertAlbum" runat="server" Text="Insert Album" OnClick="btnInsertAlbum_Click" />
    </div>
</asp:Content>
