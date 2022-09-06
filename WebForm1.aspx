<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="kudvenkat81.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style6 {
            width: 169px;
        }
        .auto-style7 {
            width: 169px;
            height: 25px;
        }
        .auto-style8 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">

           <table>
               <tr>
                   <td>
                       Country code:
                   </td>
                   <td>
                       <asp:TextBox ID="txtcode" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="True"></asp:TextBox>
                   </td>
               </tr>

               <tr>
                   <td>
                       Name:
                   </td>
                   <td>
                       <asp:TextBox ID="txtname" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                   </td>
               </tr>

               <tr>
                   <td>
                       Capital:
                   </td>
                   <td>
                       <asp:TextBox ID="txtcapital" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td colspan="2">
                       <asp:Label ID="Label1" runat="server" Forecolor="Red"></asp:Label>
                   </td>
               </tr>
           </table>

        </div>
    </form>
</body>
</html>
