<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="First.Login" %>
<%@Register Src="~/WebUserControl1.ascx" TagPrefix="MUC" TagName="MyControl" %>
<!DOCTYPE html>

<!doctype html>
<html lang="en" data-bs-theme="auto">
  <head><script src="../assets/js/color-modes.js"></script>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors">
    <meta name="generator" content="Hugo 0.111.3">
    <title>Signin Template · Bootstrap v5.3</title>

    <link rel="canonical" href="https://getbootstrap.com/docs/5.3/examples/sign-in/">

    

    <link href="Content/bootstrap.min.css" rel="stylesheet" />



    


    <!-- Custom styles for this template -->
   
          <link href="Content/sign-in.css" rel="stylesheet" />
  </head>
  <body class="text-center">
<main class="form-signin w-100 m-auto">
  <form runat="server">
    <img class="mb-4" src="../assets/brand/bootstrap-logo.svg" alt="" width="72" height="57">
    <h1 class="h3 mb-3 fw-normal">Please sign in</h1>

    <div class="form-floating">
      <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com" runat="server">
      <label for="floatingInput">Email address</label>
    </div>
    <div class="form-floating">
      <input type="password" class="form-control" id="floatingPassword" placeholder="Password" runat="server">
      <label for="floatingPassword">Password</label>
    </div>

    <div class="checkbox mb-3">
      <label>
        <input type="checkbox" value="remember-me"> Remember me
      </label>
    </div>
   <%-- <button class="w-100 btn btn-lg btn-primary" type="submit">Sign in</button>--%>
    <asp:Button ID="btnsignIn" runat="server" CssClass="w-100 btn btn-lg btn-primary" Text="Sign in" OnClick="btnsignIn_Click" />
    <p class="mt-5 mb-3 text-body-secondary">&copy; 2017–2023</p>
  </form>
</main> 
     <MUC:MyControl Id="control1" runat="server"></MUC:MyControl>
  </body>
</html>
