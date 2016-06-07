<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Vms.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 187px;
        }
         body{
             
         }
    </style>
    <script type="text/javascript">
          function preventBack() {
              window.history.forward();
           <%--   window.history.back();--%>
          }
          setTimeout("preventBack()", 0);
          window.onunload = function () { null };
    </script>
    <!--bootstrap-->
        <script type="text/javascript" src="Scripts/jquery-2.2.3.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/signin.css" rel="stylesheet" />
    <link href='https://fonts.googleapis.com/css?family=Oswald' rel='stylesheet' type='text/css'/>
    <link href='https://fonts.googleapis.com/css?family=Roboto+Condensed' rel='stylesheet' type='text/css'/>
</head>
<body style="background-color:white;background-image:url(Images/651914.jpg);">
   
        <center>
            <h1 class="text-primary" style="font-family: 'Oswald', sans-serif;">
                    <asp:Label ID="Label1" runat="server"
                        ForeColor="Red"  
                        Text="Vehicle Management System"></asp:Label>
                </h1>
              </center>
                
               
    <form id="form1" runat="server" class="form-signin">
   
                  <center>
                   <h3 class="form-signin-heading" style="font-family: 'Roboto Condensed', sans-serif;color:red" >
                    User login
                        
          </h3>
                  </center> 
                   
                
                    <asp:TextBox ID="uname" runat="server"  placeholder="User Name" CssClass="form-control"  required autofocus></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="uname" ErrorMessage="*Mandetory Field"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="uname" ErrorMessage="Not a valid name" 
                        ValidationExpression="[a-zA-Z ]*"></asp:RegularExpressionValidator>
                    
                    <asp:TextBox ID="pasw" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password" required autofocus></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="pasw" ErrorMessage="*Mandetory Field"></asp:RequiredFieldValidator>
                <br />
              

                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit"  class="btn btn-lg btn-primary btn-block"/>
           <asp:Label ID="err_message" runat="server" EnableTheming="True"  
                        Text="Not a valid customer.Please register yourself by" Visible="False"></asp:Label>

        <asp:HyperLink ID="new_user" runat="server" EnableTheming="True"
            NavigateUrl="~/registration.aspx" Visible="False">Clicking here(new user click here)</asp:HyperLink>
                
   
    
    </form>
          
               
     
</body>
</html>
