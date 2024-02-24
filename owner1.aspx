<%@ Page Title="" Language="C#" MasterPageFile="~/data.master" AutoEventWireup="true" CodeFile="owner1.aspx.cs" Inherits="owner1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server" >
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
        <td style="width: 174px">&nbsp;</td>
        <td>
            <table class="auto-style6" style="width: 89%; background-color="black ""  >
                <tr>
                    <td colspan="2" style="text-align: center; height: 52px;"><strong>
                        <br />
                        FILE UPLOAD<br />
                        </strong></td>
                </tr>
                <tr>
                    <td style="width: 105px; height: 40px;">KEYWORD</td>
                    <td style="height: 40px">
                        <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="151px" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Fill it"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 105px" class="auto-style9">FILE NAME</td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" Height="34px" Width="242px" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 105px" class="auto-style9">
                        <br />
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="UPLOAD" style="height: 26px" />
                    </td>
                </tr>
            </table>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

