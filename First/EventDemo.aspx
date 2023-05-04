<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventDemo.aspx.cs" Inherits="First.EventDemo" %>

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
                    <td>Nationality:
                        <asp:CheckBox ID="cb1" runat="server" Text="Indian" 
                            OnCheckedChanged="cb1_CheckedChanged" AutoPostBack="true"/>
                    </td>
                </tr>
                <tr>
                    <td>
                      City:  <asp:DropDownList ID="ddl1" runat="server"
                          OnSelectedIndexChanged="ddl1_SelectedIndexChanged" AutoPostBack="true" >
                          <asp:ListItem Text="Pune" Value="Pune"></asp:ListItem>
                          <asp:ListItem Text="Mumbai" Value="Mumbai"></asp:ListItem>
                          <asp:ListItem Text="Satara" Value="Satara"></asp:ListItem>
                             </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btn1" runat="server" Text="Click Me" OnClick="btn1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
