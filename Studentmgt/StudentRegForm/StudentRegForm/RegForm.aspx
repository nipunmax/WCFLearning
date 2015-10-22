<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegForm.aspx.cs" Inherits="StudentRegForm.RegForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Arial">
        <h1 style="color:silver; text-align:center;" >Employee Registator </h1>
        <table>
            <tr><td><asp:Label ID="Label1" runat="server" Text="ID"></asp:Label></td>
                <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>

            <tr><td><asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
            
            <tr><td><asp:Label ID="Label3" runat="server" Text="Address"></asp:Label></td>
                <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td></td></tr>
            
            <tr><td><asp:Label ID="Label4" runat="server" Text="Age"></asp:Label></td>
                <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td><td></td></tr>
            
            <tr><td><asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label></td>
                <td><asp:RadioButton ID="Male" runat="server" Text="Male" OnCheckedChanged="Male_CheckedChanged" AutoPostBack="True" /></td>
                <td><asp:RadioButton ID="Female" runat="server" Text ="Female         " OnCheckedChanged="Female_CheckedChanged" AutoPostBack="True"/></td></tr>
            
            <tr><td><asp:Label ID="Label6" runat="server" Text="Education"></asp:Label></td>
                <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td><td></td></tr>
            
            
            <tr><td><asp:Label ID="Label7" runat="server" Text="Mobile Number"></asp:Label></td>
                <td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td><td></td></tr>

            <tr><td><asp:Label ID="Label8" runat="server" Text="Email"></asp:Label></td>
               <td><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td><td></td></tr>

            <tr><td><asp:Label ID="Label9" runat="server" Text="Contact Method"></asp:Label></td>
                <td><asp:CheckBox ID="Mobile" runat="server" Text ="Mobile"/></td><td><asp:CheckBox ID="Email" Text="Email" runat="server" /></td></tr>
            

            
            <tr><td><asp:Button ID="Button4" runat="server" Text="Insert" OnClick="Button4_Click" /></td>
                <td><asp:Button ID="Button3" runat="server" Text="Search" OnClick="Button3_Click" /></td><td>
                    <asp:Button ID="Button2" runat="server" Text="Delete" Width="62px" OnClick="Button2_Click" /></td>
                <td><asp:Button ID="Button1" runat="server" Text="Clear" Width="62px" OnClick="Button1_Click" /></td>
            </tr>
            
          
        </table>    
    </div>
    </form>
</body>
</html>
