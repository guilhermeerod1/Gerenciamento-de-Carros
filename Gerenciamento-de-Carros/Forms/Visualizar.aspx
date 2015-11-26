<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Visualizar.aspx.cs" Inherits="Gerenciamento_de_Carros.Forms.Visualizar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate></HeaderTemplate>
            <ItemTemplate></ItemTemplate>
            <FooterTemplate></FooterTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
