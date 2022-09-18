<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Relampago.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/Miestilo.css" rel="stylesheet" />
    <title>Inicio de sesión</title>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
 
   <script src="https://www.google.com/recaptcha/api.js" async defer></script>
</head>
<body>
    <form class="form" runat="server">

        <h2>Inicio de sesión</h2>

        <p type="Usuario:">
            <asp:TextBox ID="tbuser" Class="input" placeholder="Ingrese su usuario" runat="server"></asp:TextBox>
        </p>
        <p type="Contraseña:">
            <asp:TextBox ID="tbpass" Class="input" TextMode="Password" placeholder="Ingrese su contraseña" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="BtnIngresar" class="boton" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click2" />
        <br />
       
        <a href="registro.aspx">Regístrate</a>

       

    </form>
</body>
</html>
