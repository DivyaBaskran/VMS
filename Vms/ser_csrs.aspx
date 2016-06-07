<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ser_csrs.aspx.cs" Inherits="Vms.ser_csrs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style8
    {
        width: 100%;
    }
    .style9
    {
        width: 485px;
    }
    .style10
    {
        width: 485px;
        height: 23px;
    }
    .style11
    {
        height: 23px;
    }
</style>
     <!--bootstrap-->
        <script type="text/javascript" src="Scripts/jquery-2.2.3.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/signin.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" 
            Text="Service Registration Screen"></asp:Label>
    </p>
<table class="style8">
    <tr>
        <td class="style9">
            <asp:Label ID="Label3" runat="server" Text="Service Id"></asp:Label>
        </td>
        <td>
            <asp:Label ID="si" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <asp:Label ID="Label4" runat="server" Text="Customer Name"></asp:Label>
        </td>
        <td>
            <asp:Label ID="cname" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style10">
            <asp:Label ID="Label5" runat="server" Text="Scheme Id"></asp:Label>
        </td>
        <td class="style11">
            <asp:Label ID="sch" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style9">
            Service Duration</td>
        <td>
            <asp:Label ID="sd" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <asp:Label ID="Label7" runat="server" Text="Service Start Date"></asp:Label>
        </td>
        <td>
            <asp:Label ID="ssd1" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <asp:Label ID="Label8" runat="server" Text="Service End Date"></asp:Label>
        </td>
        <td>
            <asp:Label ID="sed" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <asp:Label ID="Label9" runat="server" Text="Service Charge"></asp:Label>
        </td>
        <td>
            <asp:Label ID="sc" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style9">
            <asp:Label ID="Label11" runat="server" Text="Discount"></asp:Label>
        </td>
        <td>
            <asp:Label ID="dis" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>
<table class="style8">
    <tr>
        <td>
            <asp:Label ID="Label12" runat="server" Text="Amount Payable"></asp:Label>
            <asp:Label ID="dis0" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="pa" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
       
    </tr>

    
    <tr>
         
        <td>
            <br />
            <center class="control-label col-sm-5">
            <asp:Button ID="Button1" runat="server" Text="Cancel" onclick="Button1_Click"  CssClass="btn btn-danger"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Confirm" 
                onclick="Button2_Click" class="btn btn-success"
                 />
            <br /><br />
                </center>
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
