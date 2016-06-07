<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="false_insurance.aspx.cs" Inherits="Vms.false_insurance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style8
        {
            width: 100%;
        }
        .style9
        {
            height: 64px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style8">
        <tr>
            <td class="style9">
                Dear Customer,<br />
                No customer exists with this id. Insurance can not be purchased without a valid 
                purchase.<br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Go Back" />
            </td>
        </tr>
    </table>
</asp:Content>
