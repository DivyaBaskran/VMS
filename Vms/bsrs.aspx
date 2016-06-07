<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="bsrs.aspx.cs" Inherits="Vms.bsrs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style8
        {
            width: 100%;
            height: 208px;
        }
        .style9
        {
            width: 495px;
        }
        .style10
        {
            width: 100%;
        }
    </style>
    <%-- Load jQuery from Google's CDN -->
    <!-- Load jQuery UI CSS  -->
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <!-- Load jQuery JS -->
    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <!-- Load jQuery UI Main JS  -->
    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
    <style>
        
    </style> 
 <script type="text/jscript">
     /*  jQuery ready function. Specify a function to execute when the DOM is fully loaded.  */
     $(document).ready(

     /* This is the function that will get executed after the DOM is fully loaded */
  function () {
     
        $(".dDate").datepicker({
          changeMonth: true, //this option for allowing user to select month
          changeYear: true, //this option for allowing user to select from year range
          dateFormat: 'dd/mm/yy',
          yearRange:"1900:2100"
      });
  }

);   

</script>
    --%>
      <!--bootstrap-->
        <script type="text/javascript" src="Scripts/jquery-2.2.3.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/signin.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
       <br /><br />
        <center><h2><asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Breakdown Service Registration Screen" CssClass="form-signin-heading"></asp:Label></h2></center>
       <br />
     <div class="form-group">
                <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Customer Id" class="control-label col-sm-2" for="cid"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="cid"  class="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="cid"
                    ErrorMessage="Mandatory Field."></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="cid"
                    ErrorMessage="Format should be like-'CUS-XXXX'." ValidationExpression="[C][U][S][-][0-9]{4}"></asp:RegularExpressionValidator>
               </div>
       </div>
     <div class="form-group">
                <asp:Label ID="rr" runat="server" ForeColor="Red" 
                    Text="*Customer Id is not valid" Visible="False"></asp:Label>
           
                <asp:Label ID="Label8" runat="server" Text="Break Down Date" class="control-label col-sm-2" for="brd"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="brd" class="dDate" cssclass="form-control" runat="server"  ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="brd"
                    ErrorMessage="Mandatory Field."></asp:RequiredFieldValidator>
              </div>
         </div>
             <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="Service Start Date" class="control-label col-sm-2" for="ssd"></asp:Label>
<div class="col-sm-10">
                <asp:TextBox ID="ssd" runat="server" class="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ssd"
                    ErrorMessage="Mandatory Field."></asp:RequiredFieldValidator>
               </div>
                 </div>
        <div class="form-group">
            
                <asp:Label ID="Label11" runat="server" Text="Break Down Details" class="control-label col-sm-2" for="bdd"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="bdd" runat="server" Cssclass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="bdd"
                    ErrorMessage="Mandatory Field."></asp:RequiredFieldValidator>
           </div>
            </div>
        <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="Break Down Summary" class="control-label col-sm-2" for="bds"></asp:Label>
            <div class="col-sm-10">
                <asp:DropDownList ID="bds" runat="server"  class="form-control">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Engine Failure</asp:ListItem>
                    <asp:ListItem>Tyre/Tube leakage</asp:ListItem>
                    <asp:ListItem>Battery dead/Not charging</asp:ListItem>
                    <asp:ListItem>Peripheral Damages</asp:ListItem>
                    <asp:ListItem>Wind screen broken/Cracked</asp:ListItem>
                    <asp:ListItem Value="Radiator damage">Radiator damage</asp:ListItem>
                </asp:DropDownList>
             <br /><br />
               </div>
            </div>
       
         <div class="form-group">
             <center>
                <asp:Button ID="Button1" runat="server" Text="Reset" onclick="Button1_Click"  class="btn btn-warning" />
               
                <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" class="btn btn-primary"/>
                 </center>
             </div>
        
          </div> 
</asp:Content>

