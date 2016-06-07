<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="insur_custid_confirmation.aspx.cs" Inherits="Vms.insur_custid_confirmation" %>
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
            <asp:Label ID="Label7" runat="server" Text="Customer id"></asp:Label>
&nbsp;
            <asp:TextBox ID="cust_id" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="cust_id" ErrorMessage="VALID FORMAT: 'CUS-XXXX'" 
                ValidationExpression="[C][U][S][-][0-9]{4}"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="cust_id" ErrorMessage="MANDETORY FIELD"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Search" />
        </td>
    </tr>
</table>
</asp:Content>
