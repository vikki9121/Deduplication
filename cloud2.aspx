<%@ Page Title="" Language="C#" MasterPageFile="~/CLOUD.master" AutoEventWireup="true" CodeFile="cloud2.aspx.cs" Inherits="cloud2" %>

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
    <table class="custom-table" style="width: 77%; text-align: center;">
        <tr>
            <td>&nbsp;</td>
            <td>
                <strong>
                    <asp:Label ID="Label2" runat="server" style="font-size: 24px; font-weight: bold; color: #4CAF50;" Text="INDEX DETAILS"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td style="color: #4CAF50;">FILE </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="104px" DataSourceID="SqlDataSource2" DataTextField="dup" DataValueField="dup">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=pc;Initial Catalog=deduplication1;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [dup] FROM [index1]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=PC;Initial Catalog=deduplication;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [dup] FROM [index1]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#4CAF50" Font-Bold="True" ForeColor="white" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                    <Columns>
                        <asp:BoundField DataField="file_id" HeaderText="File id" />
                        <asp:BoundField DataField="u_name" HeaderText="User name" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
