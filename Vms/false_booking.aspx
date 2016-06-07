<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="false_booking.aspx.cs" Inherits="Vms.false_booking" %>
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
    Dear Customer,</p>
<p>
    No Booking found. Please fill a purchase form.</p>

    For filling a form, please
    <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/booking.aspx">Click here</asp:HyperLink>
    <br />
    <table class="style8">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>

<p>
</p>
</asp:Content>
