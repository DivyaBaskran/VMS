<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="validate_cid.aspx.cs" Inherits="Vms.validate_cid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style8
        {
            width: 100%;
        }
    </style>
    <script type="text/javascript" src="Scripts/jquery-2.2.3.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/signin.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div  class="container">
        <br /><br /><br />
       <center>
        <div class="form-group"><asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" 
            Text="Booking Id Validation"></asp:Label></div>
           </center>
        <br />
       <div class="form-group">
       <center>
       
                              
                             <b>  <asp:Label ID="Label3" runat="server" Text="Booking ID"  class="control-label col-sm-2" for="TextBox1"></asp:Label></b> 
            <div class="col-sm-5">
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="TextBox1" ErrorMessage="Mandatory Field. "></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ControlToValidate="TextBox1" ErrorMessage="Enter in 'VEH-XXXX' Format" 
                                    ValidationExpression="[V][E][H][-][0-9]{4}"></asp:RegularExpressionValidator>
                    </div>  
            </center>   
           </div>  
       <div class="control-label col-sm-9">
           <center  >
                                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                    Text="Confirm" CssClass="btn btn-primary" />
               </center>
           <br/>
           <br />
           </div>
   
    </div>
</asp:Content>
