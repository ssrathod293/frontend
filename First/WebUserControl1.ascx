<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="First.WebUserControl1" %>
<%--<div style="width:100% ;height:200px;background-color:dodgerblue">
          <h2>Welcome to our website</h2>
      </div>--%>
<div style="width:100%;height:100px;border:1px solid black">

    <table>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnClick" runat="server" Text="Click Me" OnClick="btnClick_Click" />
            </td>
        </tr>
    </table>
</div>