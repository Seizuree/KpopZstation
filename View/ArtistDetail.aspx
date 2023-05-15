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
    <div>
        <asp:GridView ID="gvAlbumsDetail" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="gvAlbumsDetail_SelectedIndexChanging" OnRowDeleting="gvAlbumsDetail_RowDeleting" >
            <Columns>
                <asp:CommandField ButtonType="Button" HeaderText="" ShowHeader="True" ShowSelectButton="True" />
                <asp:BoundField DataField="AlbumID" HeaderText="ID" SortExpression="AlbumID"></asp:BoundField>
                <asp:BoundField DataField="AlbumImage" HeaderText="Album Image" SortExpression="AlbumImage"></asp:BoundField>
                <asp:BoundField DataField="Albumname" HeaderText="Album Name" SortExpression="AlbumName"></asp:BoundField>
                <asp:BoundField DataField="AlbumPrice" HeaderText="Album Price" SortExpression="AlbumPrice"></asp:BoundField>
                <asp:BoundField DataField="AlbumDescription" HeaderText="Album Description" SortExpression="AlbumDescription"></asp:BoundField>
                <asp:CommandField ShowDeleteButton="True" HeaderText="" ButtonType="Button"></asp:CommandField>
            </Columns>
        </asp:GridView>
        <br />
    </div>
    <div>
        <asp:Label ID="lblAlbumID" runat="server" Text="Album ID"></asp:Label> 
        <asp:TextBox ID="tbAlbumID" runat="server" Enabled="False"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblAlbumName" runat="server" Text="Album Name"></asp:Label> 
        <asp:TextBox ID="tbAlbumName" runat="server" Enabled="False"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblAlbumPrice" runat="server" Text="Album Price"></asp:Label> 
        <asp:TextBox ID="tbAlbumPrice" runat="server" Enabled="False"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblAlbumDescription" runat="server" Text="Album Description"></asp:Label> 
        <asp:TextBox ID="tbAlbumDescription" runat="server" Enabled="False"></asp:TextBox>
    </div>
    <br />
    <div>
        <asp:Button ID="btnInsertAlbum" runat="server" Text="Insert Album" OnClick="btnInsertAlbum_Click" />
        <asp:Button ID="btnUpdateAlbum" runat="server" Text="Update Album" OnClick="btnUpdateAlbum_Click" />
    </div>
</asp:Content>
