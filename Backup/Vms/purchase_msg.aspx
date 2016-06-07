<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="purchase_msg.aspx.cs" Inherits="Vms.purchase_msg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style8
        {
            width: 100%;
        }
        .style9
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Dear Customer,<br />
        <table class="style8">
            <tr>
                <td>
                    Your Customer Id
                    <asp:Label ID="cid" runat="server" Text="C_Id"></asp:Label>
&nbsp;and your date of delivery for the vehicle is
                    <asp:Label ID="edod" runat="server" Text="EDoD"></asp:Label>
&nbsp;and warranty expiry date is
                    <asp:Label ID="wed" runat="server" Text="WExD"></asp:Label>
                    .
                    <br />
                    Your Servicing dates are</td>
            </tr>
            <tr>
                <td class="style9">
                    1st&nbsp; Service&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Label ID="d1" runat="server" Text="date1"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    2nd Service&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="d2" runat="server" Text="date2"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    3rd Service&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="d3" runat="server" Text="date3"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    4th&nbsp; Service&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="d4" runat="server" Text="date4"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
