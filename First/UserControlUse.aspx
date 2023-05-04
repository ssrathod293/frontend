<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserControlUse.aspx.cs" Inherits="First.UserControlUse" %>
<%@Register Src="~/WebUserControl1.ascx" TagPrefix="MUC" TagName="MyUserControl" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Name:
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnsubmit" runat="server" Text="Click Me" OnClick="btnsubmit_Click" />
                    </td>
                </tr>
            </table>
            <MUC:MyUserControl ID="MyControl" runat="server" />
        </div>

    </form>
</body>
</html>
