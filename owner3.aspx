<%@ Page Title="" Language="C#" MasterPageFile="~/data.master" AutoEventWireup="true" CodeFile="owner3.aspx.cs" Inherits="owner3" %>

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
    <table class="auto-style6">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
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
                    <asp:BoundField DataField="r_id" HeaderText="Request id" />
                    <asp:BoundField DataField="file_id" HeaderText="file_id" />
                    <asp:BoundField DataField="file_name" HeaderText="file_name" />
                    <asp:BoundField DataField="name" HeaderText="name" />
                </Columns>
            </asp:GridView>
            <br />
        </td>
    </tr>
    <tr>
        <td>
            <table __designer:mapid="85" class="auto-style13" style="width: 344px">
                <tr __designer:mapid="86">
                    <td __designer:mapid="87" class="auto-style16" style="width: 121px">&nbsp;</td>
                    <td __designer:mapid="88" class="auto-style15" style="width: 23px">&nbsp;</td>
                    <td __designer:mapid="89">&nbsp;</td>
                </tr>
                <tr __designer:mapid="8a">
                    <td __designer:mapid="8b" class="auto-style16" style="width: 121px">
                        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td __designer:mapid="8d" class="auto-style15" style="width: 23px">&nbsp;</td>
                    <td __designer:mapid="8e">
                        <asp:TextBox ID="TextBox1" runat="server" Height="31px" Width="137px"></asp:TextBox>
                    </td>
                </tr>
                <tr __designer:mapid="90">
                    <td __designer:mapid="91" class="auto-style16" style="width: 121px">&nbsp;</td>
                    <td __designer:mapid="92" class="auto-style15" style="width: 23px">&nbsp;</td>
                    <td __designer:mapid="93">&nbsp;</td>
                </tr>
                <tr __designer:mapid="94">
                    <td __designer:mapid="95" class="auto-style16" style="width: 121px">
                        <asp:Label ID="Label3" runat="server" Text="File_id"></asp:Label>
                    </td>
                    <td __designer:mapid="97" class="auto-style15" style="width: 23px">&nbsp;</td>
                    <td __designer:mapid="98">
                        <asp:TextBox ID="TextBox2" runat="server" Height="32px" Width="135px"></asp:TextBox>
                    </td>
                </tr>
                <tr __designer:mapid="9a">
                    <td __designer:mapid="9b" class="auto-style16" style="width: 121px">&nbsp;</td>
                    <td __designer:mapid="9c" class="auto-style15" style="width: 23px">&nbsp;</td>
                    <td __designer:mapid="9d">&nbsp;</td>
                </tr>
                <tr __designer:mapid="9e">
                    <td __designer:mapid="9f" class="auto-style16" style="width: 121px">
                        <asp:Label ID="Label4" runat="server" Text="File name"></asp:Label>
                    </td>
                    <td __designer:mapid="a1" class="auto-style15" style="width: 23px">&nbsp;</td>
                    <td __designer:mapid="a2">
                        <asp:TextBox ID="TextBox3" runat="server" Height="28px" Width="135px"></asp:TextBox>
                    </td>
                </tr>
                <tr __designer:mapid="a4">
                    <td __designer:mapid="a5" class="auto-style16" style="width: 121px">&nbsp;</td>
                    <td __designer:mapid="a6" class="auto-style15" style="width: 23px">&nbsp;</td>
                    <td __designer:mapid="a7">
                        &nbsp;</td>
                </tr>
                <tr __designer:mapid="a8">
                    <td __designer:mapid="a9" class="auto-style16" style="width: 121px">
                        <asp:Label ID="Label5" runat="server" Text="Request id"></asp:Label>
                    </td>
                    <td __designer:mapid="ab" class="auto-style15" style="width: 23px">&nbsp;</td>
                    <td __designer:mapid="ac">&nbsp;<asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="134px" style="margin-left: 0px"></asp:TextBox>
                    </td>
                </tr>
                <tr __designer:mapid="ae">
                    <td __designer:mapid="af" class="auto-style16" style="width: 121px">&nbsp;</td>
                    <td __designer:mapid="b0" class="auto-style15" style="width: 23px">&nbsp;</td>
                    <td __designer:mapid="b1">&nbsp;</td>
                </tr>
                <tr __designer:mapid="b2">
                    <td __designer:mapid="b3" class="auto-style16" style="width: 121px">&nbsp;</td>
                    <td __designer:mapid="b4" class="auto-style15" style="width: 23px">&nbsp;</td>
                    <td __designer:mapid="b5">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Accept" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Reject" />
                        <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
                        <asp:Label ID="Label7" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

