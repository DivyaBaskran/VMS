<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="csrs.aspx.cs" Inherits="Vms.csrs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style8
        {
            width: 100%;
            height: 160px;
        }
        .style9
        {
            width: 543px;
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
            Text="Confirm Service Registration Screen"></asp:Label>
            </center>
         <br />
   <div class="form-group">
                <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Service Id" class="control-label col-sm-2" for="sid"></asp:Label>
            <div class="col-sm-7">
                <asp:TextBox ID="sid" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="sid"
                    ErrorMessage="Mandatory Field."></asp:RequiredFieldValidator>
                </div>
            </div>
         <br /><br />
        <div class="form-group">
                <asp:Label ID="Label4" runat="server" Font-Size="Medium" 
                    Text="Service End Date" class="control-label col-sm-2" for="sed"></asp:Label>
           <div class="col-sm-7">
                <asp:TextBox ID="sed" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="sed"
                    ErrorMessage="Mandatory Field."></asp:RequiredFieldValidator>
               </div>
            </div>
        <br /><br />
         <div class="form-group">
                <asp:Label ID="Label5" runat="server" Font-Size="Medium" Text="Charges" class="control-label col-sm-2" for="charge"></asp:Label>
             <div class="col-sm-7">
                <asp:TextBox ID="charge" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="charge"
                    ErrorMessage="Mandatory Field."></asp:RequiredFieldValidator>
            </div>
             </div>
        <br /><br />
        <div class="form-group">
                <asp:Label ID="Label6" runat="server" Font-Size="Medium" Text="Discount" class="control-label col-sm-2" for="dis"></asp:Label>
           <div class="col-sm-7">
                <asp:TextBox ID="dis" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="dis"
                    ErrorMessage="Mandatory Field."></asp:RequiredFieldValidator>
            </div>
            </div>
        <br /><br />
        <div class="form-group">
            <center>
            <asp:Button  ID="Button3" runat="server" onclick="Button3_Click" Text="Cancel" CssClass="btn btn-warning"/>
                   
               
                <asp:Button ID="Button2" runat="server" Text="Confirm" CssClass="btn btn-primary"  
                    onclick="Button2_Click" />
                </center>
            </div>
        <br /><br />
     </div>      
</asp:Content>
