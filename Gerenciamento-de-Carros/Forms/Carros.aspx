<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carros.aspx.cs" Inherits="Gerenciamento_de_Carros.Forms.Carros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Cadastro de Carros</legend>
            <table>
                <tr>
                    <td>Modelo:</td>
                    <td><asp:TextBox ID="txtModelo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Preço:</td>
                    <td><asp:TextBox ID="txtPreco" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ano do Modelo:</td>
                    <td><asp:TextBox ID="txtAnoModelo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Km:</td>
                    <td><asp:TextBox ID="txtKm" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Cor:</td>
                    <td><asp:TextBox ID="txtCor" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Combustível:</td>
                    <td><asp:TextBox ID="txtCombustivel" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnLimpar" runat="server" Text="Button" /></td>
                    <td><asp:Button ID="btnCadastrar" runat="server" Text="Button" /></td>
                </tr>
            </table>
        </fieldset>
    </form>
</body>
</html>
