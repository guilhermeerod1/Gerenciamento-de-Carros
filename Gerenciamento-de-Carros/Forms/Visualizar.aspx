<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Visualizar.aspx.cs" Inherits="Gerenciamento_de_Carros.Forms.Visualizar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="~/Styles/style.css" />
</head>
<body>
    <header>Gerenciamento de Carros</header>
    <nav>
        <a href="Carros.aspx" class="lnk">Cadastrar</a>
    </nav>
    <main>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
            <HeaderTemplate>
                <table class="tblVisualizar">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Modelo</th>
                            <th>Preço</th>
                            <th>Ano do Modelo</th>
                            <th>Cor</th>
                            <th>Combustível</th>
                            <th colspan="2">Ações</th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label ID="lblId" runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblModelo" runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblPreco" runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblAnoModelo" runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblKm" runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblCor" runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblCombustivel" runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:HyperLink ID="lnkEditar" runat="server">Editar</asp:HyperLink>                        
                                <asp:HyperLink ID="lnkExcluir" runat="server">Excluir</asp:HyperLink>
                            </td>
                        </tr>
            </ItemTemplate>
            <FooterTemplate>
                    </tbody>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
    </div>
    </form>
    </main>
    <footer>Criado por: Felipe Mendes e Guilherme Estrada Rodrigues</footer>
</body>
</html>
