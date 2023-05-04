<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListControl.aspx.cs" Inherits="First.ListControl" %>

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
                    <td>City</td>
                    <td>
                        <%--<asp:DropDownList ID="ddlcities" runat="server">
                            <asp:ListItem Value="-1" Text="--Select City---"></asp:ListItem>
                            <asp:ListItem Value="1" Text="Pune"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Mumbai"></asp:ListItem>
                            <asp:ListItem Value="3" Text="Satara"></asp:ListItem>
                        </asp:DropDownList>--%>
                        <asp:DropDownList ID="ddlcities" runat="server">
                         
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:RadioButtonList ID="rblgender" runat="server"
                           RepeatDirection="Horizontal" ></asp:RadioButtonList>
                    </td>
                </tr>
                  <tr>
                    <td>Skills</td>
                    <td>
                        <asp:CheckBoxList ID="cblist" runat="server"
                            RepeatDirection="Horizontal"></asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>Selected Skills</td>
                    <td>
                        <asp:ListBox ID="lbSelectedSkills" runat="server"></asp:ListBox>
                    </td>
                </tr>
                 <tr>
                    <td>Menu</td>
                    <td>
                        <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="Circle">
                            <asp:listitem value="Tea" text="Tea"></asp:listitem>
                            <asp:listitem value="COFFEE" text="COFFEE"></asp:listitem>
                            <asp:listitem value="Milk" text="Milk"></asp:listitem>
                        </asp:BulletedList>
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:Button ID="btnread" runat="server" Text="read values" OnClick="btnread_Click" />
                    </td>
                </tr>
                 <tr>
                    <td >
                        <asp:Button ID="btnset" runat="server" Text="set values" OnClick="btnset_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
