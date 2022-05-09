<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPloginPractice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            UserName: <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:
            <asp:TextBox TextMode="Password" ID="TxtPassword"  runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="messagelbl" runat="server" Enabled="False" Text="Label" Visible="False"></asp:Label>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Login" Width="145px" OnClick="Button1_Click1" />
        </p>
    </form>
</body>
</html>
