<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="servicing.aspx.cs" Inherits="Vms.servicing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style8
        {
            width: 100%;
            height: 109px;
        }
        .style9
        {
            width: 492px;
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
       <br /><br /><br /><center>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" 
            Text="Service Registration Screen" ></asp:Label>
       </center>
       <br />
    <div class="form-group">
               <b> <asp:Label ID="Label10" runat="server" Text="Customer Id" class="control-label col-sm-2" for="cid"></asp:Label></b>
           <div class="col-sm-5">
                <asp:TextBox ID="cid" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="cid"
                    ErrorMessage="Mandatory Field."></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="cid" ErrorMessage="Should be in format 'CUS-XXXX'." 
                    ValidationExpression="[C][U][S][-][0-9]{4}"></asp:RegularExpressionValidator>
               
                <asp:Label ID="rr1" runat="server" ForeColor="Red" 
                    Text="*Customer Id is not valid" Visible="False"></asp:Label>
          </div>
        </div>
       <br /><br />
       <div class="form-group">
               <b> <asp:Label ID="Label11" runat="server" Text="Service Duration" class="control-label col-sm-2" for="sd"></asp:Label></b>
             <div class="col-sm-5">
                <asp:DropDownList ID="sd" runat="server" cssclass="form-control">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>3 months</asp:ListItem>
                    <asp:ListItem>6 months</asp:ListItem>
                    <asp:ListItem>12 months</asp:ListItem>
                </asp:DropDownList>
           </div>
           </div>
         <br /><br />
       <div class="form-group">
           <center class="col-sm-6">
                <asp:Button ID="Button1" runat="server" Text="Reset" onclick="Button1_Click"  class="btn btn-warning" />
                <asp:Button ID="Button2" runat="server" Text="Details" class="btn btn-primary"
                    onclick="Button2_Click" />
               </center>
             <br /><br />
           </div>
      </div>     
</asp:Content>
