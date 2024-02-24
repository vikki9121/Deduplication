<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="cust1.aspx.cs" Inherits="cust1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
            <style type="text/css">
    #menu-wrapper {
        display: none;
        /* Add any other styles as needed */
    }
    .auto-style2 {
    height: 20%;
    width: 976px;
    color:white;
    background-color : black;
    
    
}
    .auto-style9 {
        border-collapse: collapse; /* Ensure borders collapse into a single border */
        width: 250px; /* Set width to 100% of the container */
        font-weight: bold; /* Make text in the table bold */
        color:black;
        

        /* Add any other styles as needed */
    }

    .auto-style9 th, .auto-style9 td {
        border: 1px solid #ddd; /* Add a border to table cells */
        padding: 8px; /* Add padding to cells */
        text-align: left; /* Align text to the left in cells */

        /* Add any other styles as needed */
    }

    .auto-style9 th {
        background-color: #f2f2f2; /* Background color for header cells */

        /* Add any other styles as needed */
    }
</style>
    <table class="auto-style7">
    <tr>
        <td colspan="2" style="text-align: center">
            <br />
            <strong>&nbsp;
            <asp:Label ID="Label1" runat="server" style="font-size: large" Text="SEARCH DATA"></asp:Label>
            <br />
            </strong></td>
    </tr>
    <tr>
        <td class="auto-style11" style="width: 240px; text-align: center">FILE NAME</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Height="33px" Width="172px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SEARCH" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
                <Columns>
                    <asp:BoundField DataField="file_id" HeaderText="file_id" />
                    <asp:BoundField DataField="org" HeaderText="file_name" />
                    <asp:BoundField DataField="u_name" HeaderText="name" />
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>

