<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" 
   MasterPageFile="~/MYCite.Master" Inherits="First.SignUp" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" >
     <form id="form1" >
        <div class="container">
            <h1>Sign IN</h1>
         <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SignIn.aspx">SignIn</asp:HyperLink>

        </div>
    </form>
</asp:Content>

<asp:Content ID="MyContent" runat="server" ContentPlaceHolderID="sidebarContent">
        <ul>
        <li>HTML</li>
        <li>CSS</li>
        <li>JAVASCRIPT</li>
    </ul>
   </asp:Content>


