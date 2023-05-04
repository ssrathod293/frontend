<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="First.Register" %>
<%@Register Src="~/WebUserControl1.ascx" TagPrefix="MUC" TagName="MyControl" %>

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
                    <td>name</td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>password</td>
                    <td>
                        <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txtaddress" TextMode="MultiLine" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:RadioButton ID="rdmale" runat="server" Text="Male" TextAlign="Right" 
                            GroupName="Gender"/>
                        <asp:RadioButton ID="rdfemale" runat="server" Text="Female" TextAlign="Right" GroupName="Gender" />
                    </td>
                </tr>
                <tr>
                    <td>Prepared skills for Mock</td>
                    <td>
                        <asp:CheckBox ID="cbsql" runat="server" Text="SQL" textalign="Right"/>
                        <asp:CheckBox ID="cbCsharp" runat="server" Text="C#" textalign="Right"/>
                        <asp:CheckBox ID="cbjavascript" runat="server" Text="Javascript" textalign="Right"/>
                        <asp:CheckBox ID="cbbootstrap" runat="server" Text="Bootstrap" textalign="Right"/>
                        <asp:CheckBox ID="cbAdonet" runat="server" Text="Ado.net" textalign="Right"/>
                    </td>
                </tr>
                <tr>
                    <td>Date Of Birth</td>
                    <td>
                        <asp:TextBox ID="txtDob" runat="server" TextMode="Date" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnRead" runat="server" Text="Read Values" OnClick="btnRead_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form> 
         <MUC:MyControl ID="MyControl1" runat="server"/>

</body>
</html>
