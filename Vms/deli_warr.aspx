<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="deli_warr.aspx.cs" Inherits="Vms.deli_warr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
            Text="Vehicle Purchase &amp; Delivery Details"></asp:Label>
    </center>
       <div class="form-group">
                <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Customer Name" class="control-label col-sm-2" for="c_name"></asp:Label>
           <div class="col-sm-7">
                <asp:TextBox ID="c_name" runat="server" ontextchanged="TextBox1_TextChanged" CssClass="form-control"></asp:TextBox>
           </div>
           </div>
       <br /><br />
       <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Email Id" class="control-label col-sm-2" for="e_mail"></asp:Label>
            <div class="col-sm-7">
                <asp:TextBox ID="e_mail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
           </div>
       <br /><br />
       <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Contact" class="control-label col-sm-2" for="cont"></asp:Label>
             <div class="col-sm-7">
                <asp:TextBox ID="cont" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
           </div>
       <br /><br />
        <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Address" class="control-label col-sm-2" for="addr"></asp:Label>
            <div class="col-sm-7">
                <asp:TextBox ID="addr" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
            </div>
       <br /><br />
       <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Pincode" class="control-label col-sm-2" for="pin"></asp:Label>
             <div class="col-sm-7">
                <asp:TextBox ID="pin" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
           </div>
       <br /><br />
        <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="Model Number" class="control-label col-sm-2" for="model"></asp:Label>
           <div class="col-sm-7">
                <asp:DropDownList ID="model" runat="server" 
                    Enabled="False" CssClass="form-control">
                    <asp:ListItem>SUZK-0001</asp:ListItem>
                    <asp:ListItem>SUZK-0002</asp:ListItem>
                    <asp:ListItem>SUZK-0003</asp:ListItem>
                    <asp:ListItem>SUZK-0004</asp:ListItem>
                    <asp:ListItem>SUZK-0005</asp:ListItem>
                </asp:DropDownList>
            </div>
            </div>
       <br /><br />
       <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="Chasis Number" class="control-label col-sm-2" for="cha"></asp:Label>
             <div class="col-sm-7">
                <asp:TextBox ID="cha" runat="server" Enabled="False" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="cha" ErrorMessage="This field can not be left blank."></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="cha" ErrorMessage="It should be 7 digit number" 
                    ValidationExpression="[1-9]{1}[0-9]{6}"></asp:RegularExpressionValidator>
           </div>
           </div>
       <br /><br />
        <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="Date of Delivery" class="control-label col-sm-2" for="dod"></asp:Label>
            <div class="col-sm-7">
                <asp:TextBox ID="dod" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
       </div>
       <br /><br />
        <div class="form-group">

            <center>
                <asp:Button ID="Button1" runat="server" Text="Reset" onclick="Button1_Click" CssClass="btn btn-warning" />
                <asp:Button ID="Button2" runat="server" Text="Submit" onclick="Button2_Click" CssClass="btn btn-primary" />
                </center>
            </div>
       <br />
       </div>
           
</asp:Content>
