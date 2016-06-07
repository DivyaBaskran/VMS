<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="booking.aspx.cs" Inherits="Vms.booking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style8
        {
            width: 100%;
            height: 407px;
        }
        .style9
        {
            width: 522px;
        }
        .style10
        {
            width: 100%;
        }
    </style>
     <!--bootstrap-->
        <script type="text/javascript" src="Scripts/jquery-2.2.3.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/signin.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="container">
       <br /><br /><br />
       <center>
       <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" 
            Text="Vehicle Booking" ></asp:Label>
    </center>
      
          
    <div class="form-group">

       
 
                <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Customer Name"  class="control-label col-sm-2" for="c_name"></asp:Label>
             <div class="col-sm-10">
                 <asp:TextBox ID="c_name" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="c_name" ErrorMessage="User name can not be left blank."></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="c_name" ErrorMessage="Only Alphabets are allowed." 
                    ValidationExpression="[a-zA-Z ]*"></asp:RegularExpressionValidator>
                 </div>
    </div>
           
                
           <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Email Id" class="control-label col-sm-2" for="e_mail"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="e_mail" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="e_mail" ErrorMessage="Should be valid Email Id" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="e_mail" ErrorMessage="Cannot left blank"></asp:RequiredFieldValidator>
                </div>
               </div>
              <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Contact"  class="control-label col-sm-2" for="contact"></asp:Label>
           <div class="col-sm-10">
                <asp:TextBox ID="contact"  CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                    ControlToValidate="contact" ErrorMessage="Should be 10 Digit number" 
                    ValidationExpression="[1-9]{1}[0-9]{9}"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="contact" ErrorMessage="Contact Can not be left blank"></asp:RequiredFieldValidator>
               </div>
                  </div>
              <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Address" class="control-label col-sm-2" for="address"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="address" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="address" ErrorMessage="Address Can not be left blank"></asp:RequiredFieldValidator>
            </div>
                  </div>
              <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Pincode"  class="control-label col-sm-2" for="pin"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="pin" CssClass="form-control"  runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="pin" ErrorMessage="Pincode can not be left blank"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                    ControlToValidate="pin" ErrorMessage="Should contain 6 digit number." 
                    ValidationExpression="[1-9]{1}[0-9]{5}"></asp:RegularExpressionValidator>
            </div>
                   </div>
               <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="Model Number"  class="control-label col-sm-2" for="model_no"></asp:Label>
            <div class="col-sm-10">
                <asp:DropDownList ID="model_no" runat="server" CssClass="form-control">
                    <asp:ListItem Value="0">--Select--</asp:ListItem>
                    <asp:ListItem Value="1">SUZK-0001</asp:ListItem>
                    <asp:ListItem Value="2">SUZK-0002</asp:ListItem>
                    <asp:ListItem Value="3">SUZK-0003</asp:ListItem>
                    <asp:ListItem Value="4">SUZK-0004</asp:ListItem>
                    <asp:ListItem Value="5">SUZK-0005</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="model_no" InitialValue="0" ErrorMessage="Please select Model no."></asp:RequiredFieldValidator>
           </div>
                    </div>
             <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="Date Of Booking " class="control-label col-sm-2" for="dob"></asp:Label>
               
            
                  <div class="col-sm-10">
                <asp:TextBox ID="dob" runat="server" BorderStyle="None" ReadOnly="True" CssClass="form-control"></asp:TextBox>
                       <br /><br />
</div>
                 </div>
      
       <center>
                <asp:Button ID="Button1" runat="server" Text="Reset" onclick="Button1_Click" class="btn btn-warning" />
                <asp:Button ID="Button2" runat="server" Text="Submit" onclick="Button2_Click" class="btn btn-primary"/>
            </center>
          </div>
    <br />
</asp:Content>
