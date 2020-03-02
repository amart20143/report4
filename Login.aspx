<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="group4LICA.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 218px;
        }
        .auto-style4 {
            height: 73px;
            width: 768px;
        }
        .auto-style5 {
            width: 138px;
            height: 73px;
        }
        .auto-style6 {
            width: 711px;
            height: 73px;
        }
        .auto-style7 {
            height: 28px;
            width: 768px;
        }
        .auto-style8 {
            width: 138px;
            height: 28px;
        }
        .auto-style9 {
            width: 711px;
            height: 28px;
        }
        .auto-style11 {
            width: 138px;
        }
        .auto-style12 {
            width: 711px;
        }
        .auto-style13 {
            width: 768px;
        }
    </style>
</head>
<body style="height: 159px">
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Label ID="lblLogin" runat="server" Text="User Login"></asp:Label>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">
                    <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style11">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style11">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" />
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
