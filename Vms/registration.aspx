<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="Vms.registration" %>

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
            width: 325px;
        }
    </style>
     <!--bootstrap-->
        <script type="text/javascript" src="Scripts/jquery-2.2.3.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/signin.css" rel="stylesheet" />
    <link href='https://fonts.googleapis.com/css?family=Raleway:700italic,700' rel='stylesheet' type='text/css'/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container" style="font-family: 'Raleway', sans-serif;">
    
       <div>
                  <center> <h3>Register yourself</h3></center> 
           </div>
        <div class="form-group">
                                <asp:Label ID="Label1" runat="server" Text="User Name" class="control-label col-sm-3" for="un"></asp:Label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="un" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="un" ErrorMessage="Mandetory Field"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ControlToValidate="un" ErrorMessage="Not a valid name" 
                                    ValidationExpression="[a-zA-Z ]*"></asp:RegularExpressionValidator>
                           </div>
            </div>
       <br /><br /><br />
        <div class="form-group">
                                <asp:Label ID="Label2" runat="server" Text="Password" class="control-label col-sm-3" for="pa"></asp:Label>
                             <div class="col-sm-6">
                                <asp:TextBox ID="pa" runat="server" TextMode="Password"  CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="pa" ErrorMessage="Mandetory Field"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                    ControlToValidate="pa" 
                                    ErrorMessage="Not a valid password.The password's first character must be a letter, it must contain at least 4 characters and no more than 15 characters and no characters other than letters, numbers and the underscore may be used" 
                                    ValidationExpression="^[a-zA-Z]\w{3,14}$"></asp:RegularExpressionValidator>
                         </div>
          
            </div> 
          <div><br /></div>
         <div class="form-group">
           
                             <br /> <br /><br /> <asp:Label ID="cfrm_pwd" runat="server" Text="Confirm Password" class="control-label col-sm-3" for="cp"></asp:Label>
            
               <div class="col-sm-6">
                                <asp:TextBox ID="cp" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ControlToValidate="cp" ErrorMessage="Mandetory Field"></asp:RequiredFieldValidator>
                          
                                <asp:Label ID="err" runat="server" ForeColor="Red" 
                                    Text="Try again....error in password confirmation" Visible="False"></asp:Label>
                           </div> 
             </div>
        <br /><br />
         <div class="form-group">
             <div class="col-sm-10">
                            <center>  <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" CssClass="btn btn-primary" /></center>  
                 </div>
                       </div>     
    </div>
    </form>
</body>
</html>
