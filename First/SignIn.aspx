<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs"
    MasterPageFile="~/MYCite.Master" Inherits="First.SignIn" %>
<%@ Register Src="~/sidebarControl.ascx" TagPrefix="SB" TagName="Sidebar"  %>
<asp:Content ID="MyContent" runat="server" ContentPlaceHolderID="MainContent">

        <div class="container">
            <h1>Login</h1>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SignUp.aspx">SignUp</asp:HyperLink>
        </div>
    <h3>Webform</h3>
<asp:TextBox ID="txtWebFormName" runat="server"></asp:TextBox>
<asp:Button ID="btnWebForm" runat="server" Text="WebFormButton" OnClick="btnWebForm_Click" />

</asp:Content>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="sidebarContent">
   <%-- <ul>
        <li>SQL</li>
        <li>C#</li>
        <li>LINQ</li>
    </ul>--%>
    <SB:Sidebar ID="Sidebar1" runat="server" />  
    </asp:Content> 