<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorUI.aspx.cs" Inherits="CalculatorApp_10_1_15.CalculatorUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
        <td>Department</td>
       <td> <asp:DropDownList ID="departmentDropDownList" runat="server">
        </asp:DropDownList></td>        
        </tr>
            <tr>
        <td>First Name</td>
       <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>        
        </tr>
        <tr>
        <td>Address</td>
       <td>    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>        
        </tr>
    </table>
    
        <br />
        <asp:Button ID="saveButton" runat="server" OnClick="addButton_Click" Text="Save" />
&nbsp;&nbsp;
        <asp:Button ID="retrieveButton" runat="server" Text="Retrieve" OnClick="retrieveButton_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
