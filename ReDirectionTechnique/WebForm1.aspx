<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ReDirectionTechnique.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Web Form1 content</h1>
            <%--<a href="http://www.google.com">Visit Google</a>|
            <a href="WebForm2.aspx" >Visit WebForm2</a>--%>
            <%--<asp:HyperLink ID="HyperLink1" runat="server"
                NavigateUrl="http://www.google.com">visit Google</asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" runat="server"
                NavigateUrl="~/WebForm2.aspx">web form2</asp:HyperLink>--%>



         </div>
    </form>
</body>
</html>
