<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainView.Master" AutoEventWireup="true" CodeBehind="InsertAlbum.aspx.cs" Inherits="KpopZstation.View.InsertAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Album</h1>
    <hr />
    <div>
        <asp:Label ID="lblAlbName" runat="server" Text="Album Name"></asp:Label>
        <asp:TextBox ID="tbAlbName" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="lblAlbNameRequiredValidation" runat="server" ErrorMessage="Please fill the Album Name!" ControlToValidate="tbAlbName" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="lblAlbNameCharacterValidation" runat="server" ErrorMessage="Album name must be under 50 characters!" ControlToValidate="tbAlbName" ValidationExpression=".{0,50}" Display="Dynamic"></asp:RegularExpressionValidator>       
    </div>
    <div>
        <asp:Label ID="lblAlbDesc" runat="server" Text="Album Description"></asp:Label>
        <asp:TextBox ID="tbAlbDesc" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="lblAlbDescRequiredValidation" runat="server" ErrorMessage="Please fill the Album Description!" ControlToValidate="tbAlbDesc" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="lblAlbDescCharacterValidation" runat="server" ErrorMessage="Album description must be under 255 characters!" ControlToValidate="tbAlbName" ValidationExpression=".{0,255}" Display="Dynamic"></asp:RegularExpressionValidator>
    </div>
    <div>
        <asp:Label ID="lblAlbPrice" runat="server" Text="Album Price"></asp:Label>
        <asp:TextBox ID="tbAlbPrice" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="lblAlbPriceRequiredValidation" runat="server" ErrorMessage="Please fill the Album Price!" ControlToValidate="tbAlbPrice" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="lblAlbPriceRangeValidation" runat="server" ErrorMessage="Album price must be between 100000 and 1000000" ControlToValidate="tbAlbPrice" MaximumValue="1000000" MinimumValue="100000" Type="Integer" Display="Dynamic"></asp:RangeValidator>
    </div>
    <div>
        <asp:Label ID="lblAlbStock" runat="server" Text="Album Stock"></asp:Label>
        <asp:TextBox ID="tbAlbStock" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="lblAlbStockRequiredValidation" runat="server" ErrorMessage="Please fill the Album Stock!" ControlToValidate="tbAlbStock" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="lblAlbStockRangeValidation" runat="server" ErrorMessage="Album stock must be more than 0" ControlToValidate="tbAlbStock" MinimumValue="1" Type="Integer" Display="Dynamic" MaximumValue="10000000"></asp:RangeValidator>
    </div>
    <div>
        <asp:Label ID="lblImage" runat="server" Text="Album Image"></asp:Label>
        <asp:FileUpload ID="upImage" runat="server" />
        <br />
        <asp:RegularExpressionValidator ID="upImageExtensionValidation" runat="server" ErrorMessage="Image file extension must be .png, .jpg, .jpeg, or .jfif" ControlToValidate="upImage" ValidationExpression="(.png|.jpg|.jpeg|.jfif)$" Display="Dynamic"></asp:RegularExpressionValidator>
        <asp:CustomValidator ID="upImageSizeValidation" runat="server" ErrorMessage="Image file size must be lower than 2MB" ControlToValidate="upImage" ClientValidationFunction="FileSizeValidation"></asp:CustomValidator>
    </div>
    <div>
        <asp:Button ID="btnSubmitAlbum" runat="server" Text="Submit Album" OnClick="btnSubmitAlbum_Click" />
    </div>
</asp:Content>
