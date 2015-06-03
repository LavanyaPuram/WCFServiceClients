<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Employee Information</h2>
    <table style="border:2px solid black;font-family:Arial">
        <tr>
            <td width="52%"><b>Id</b></td>
            <td width="55%"><asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><b>Name</b></td>
           <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><b>Gender</b></td>
            <td><asp:TextBox ID="txtGender" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><b>DOB</b></td>
            <td><asp:TextBox ID="txtDOB" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2"></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnGet" runat="server" Text="GetEmployee" Width="157" OnClick="btnGet_Click" /></td>
            <td><asp:Button ID="btnSave" runat="server" Text ="Save Employee" Width="157" OnClick="btnSave_Click" /></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnUpdate" runat="server" Width="157" Text="Update Employee" OnClick="btnUpdate_Click" /></td>
            <td><asp:Button ID="btnDelete" runat="server" Width="157" Text="Delete Employee" OnClick="btnDelete_Click" /></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Label ID="lblMessage" runat="server" ForeColor="Green" Font-Bold="true"></asp:Label></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
