<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Insurance.aspx.cs" Inherits="Vms.Insurance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style8
        {
            width: 98%; 
            height: 172px;
        }
        .style9
        {
            width: 510px;
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
            Text="Vehicle Insurance Screen"></asp:Label></center>
       <br />
   <div class="form-group">
                <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Customer Name" class="control-label col-sm-2" for="cname"></asp:Label>
            <div class="col-sm-7">
                <asp:TextBox ID="cname" runat="server" ontextchanged="TextBox1_TextChanged" CssClass="form-control"></asp:TextBox>
            </div>
       </div>
              <br /><br />
      <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="Policy Issue Date" class="control-label col-sm-2" for="pid"></asp:Label>
            <div class="col-sm-7">
                <asp:TextBox ID="pid" runat="server" CssClass="form-control"></asp:TextBox>
               
            </div>
          </div>
              <br /><br />
       <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="Policy Start Date" class="control-label col-sm-2" for="psd"></asp:Label>
              <div class="col-sm-7">
                <asp:TextBox ID="psd" runat="server" CssClass="form-control"></asp:TextBox>
               </div>
           </div>
              <br /><br />
        <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Address" class="control-label col-sm-2" for="adds"></asp:Label>
             <div class="col-sm-7">
                <asp:TextBox ID="adds" runat="server" CssClass="form-control"></asp:TextBox>
            
            </div>
            </div>
              <br /><br />
       <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="Total Insured Declared Value" class="control-label col-sm-2" for="tidv"></asp:Label>
            <div class="col-sm-7">
                <asp:TextBox ID="tidv" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
       </div>
       <br /><br />
       <div class="form-group">
          <center>
                <asp:Button ID="Button1" runat="server" Text="Reset" onclick="Button1_Click" CssClass="btn btn-warning"></asp:Button>
                <asp:Button ID="Req_plc" runat="server" Text="Request For Policy" CssClass="btn btn-primary"
                    onclick="Button2_Click" ></asp:Button>
              </center>
           </div>
       <br /><br /> 
          </div>
</asp:Content>
