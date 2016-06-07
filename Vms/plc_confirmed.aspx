<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="plc_confirmed.aspx.cs" Inherits="Vms.plc_confirmed" %>
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
            Dear Policy Holder,<br />
            Your Policy Id is&nbsp;
            <asp:Label ID="p_id" runat="server" Text="plcyid"></asp:Label>
&nbsp;and your policy issue date is
            <asp:Label ID="issue_date" runat="server" Text="policy_issue_date"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="issue_date0" runat="server" Text="POLICY START DATE"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="issue_date2" runat="server" Text="START DATE"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="issue_date1" runat="server" Text="POLICY END DATE"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="issue_date3" runat="server" Text="END DATE"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
