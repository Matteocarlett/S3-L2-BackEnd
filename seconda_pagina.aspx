<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seconda_pagina.aspx.cs" Inherits="WebApplication3.seconda_pagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Seconda Pagina</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome</h2>
            <asp:Label ID="lblUsername" runat="server"></asp:Label>
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
        </div>
    </form>
</body>
</html>
