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
            <HeaderTemplate>
                <table style="border: 1px solid black;">
                    <thead>
                        <tr style="background-color: blue; color: white; font-size: larger;">
                        <th>Id</th>
                        <th>Modelo</th>
                        <th>Preço</th>
                        <th>Ano do Modelo</th>
                        <th>Cor</th>
                        <th>Combustível</th>
                        </tr>
                    </thead>
                    <tbody>
                </table>
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
        <asp:Label ID="lblMensagem" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
