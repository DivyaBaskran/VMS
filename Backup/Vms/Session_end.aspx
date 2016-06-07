<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session_end.aspx.cs" Inherits="Vms.Session_end" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td>
                Session expired.....Try again<br />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Try again" />
            </td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
