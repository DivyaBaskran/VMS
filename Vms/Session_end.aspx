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
    <!--bootstrap-->
        <script type="text/javascript" src="Scripts/jquery-2.2.3.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/signin.css" rel="stylesheet" />
</head>
<body>
    <center>
    <form id="form1" runat="server">
        
        <div class="alert-info">
    <table class="style1">
        <tr>
            <td>
                <h2>
                Session expired.....Try again</h2><br />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Try again" class="btn btn-primary" />
            </td>
        </tr>
    </table>
    <div>
    
    </div>
            </div>
            
    </form>
        </center>
</body>
</html>
