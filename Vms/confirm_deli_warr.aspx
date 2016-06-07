<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="confirm_deli_warr.aspx.cs" Inherits="Vms.confirm_deli_warr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style8
    {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
       
    <table class="style8" >
        <tr>
            <td>
                Dear Customer,</td>
        </tr>
        <tr>
            <td>
                Your Customer Id is
                <asp:Label ID="cust_id" runat="server" Text="customerid"></asp:Label>
&nbsp;and your date of delivery for the vehicle is
                <asp:Label ID="e_dod" runat="server" Text="expecteddod"></asp:Label>
&nbsp;and warranty expiry date is
                <asp:Label ID="w_dod0" runat="server" Text="warrantyddod"></asp:Label>
                .<br />
                Your Servicing dates are:-</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="servi1" runat="server" Text="1st Service"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="dat1" runat="server" Text="date1"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="servi2" runat="server" Text="2nd Service"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="dat2" runat="server" Text="date2"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="servi3" runat="server" Text="3rd Service"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="dat3" runat="server" Text="date3"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="servi4" runat="server" Text="4th Service"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="dat4" runat="server" Text="date4"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
</p>
<p>
</p>
</asp:Content>
