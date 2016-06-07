<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="confirmed_csrs.aspx.cs" Inherits="Vms.confirmed_csrs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style8
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style8">
        <tr>
            <td>
                Dear Customer,<br />
                Your service request is logged successfully. You breakdown service charges are
                <asp:Label ID="charges" runat="server" Text="Label"></asp:Label>
&nbsp;rs. and service compilation date is
                <asp:Label ID="sed" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
