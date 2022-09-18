<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="Relampago.registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/Miestilo.css" rel="stylesheet" />
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <title>Registro</title>
</head>
<body>
    <form id="form1" class="form2" runat="server">
        <h2>Registro</h2>


        <p type="Identificación:">
            <asp:TextBox ID="tbuser" Class="input" placeholder="305310973" runat="server"></asp:TextBox>
        </p>
        <p type="Nombre:">
            <asp:TextBox ID="tbname" Class="input" placeholder="Josselyn" runat="server"></asp:TextBox>
        </p>
        <p type="Apellidos:">
            <asp:TextBox ID="tblastname" Class="input" placeholder="Pérez Gómez" runat="server"></asp:TextBox>
        </p>
        <p type="Contraseña:">
            <asp:TextBox ID="tbpass" Class="input"  TextMode="Password" placeholder="xxxxxxxxx" runat="server"></asp:TextBox>
        </p>
        <p type="Correo:">
            <asp:TextBox ID="tbEmail" Class="input" placeholder="josfi874@ejemplo.com" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="BtnRegistrar" class="boton" runat="server" Text="Registrar" OnClick="BtnRegistrar_Click1" />
        <br />
        <br />

       
    </form>
</body>
</html>
