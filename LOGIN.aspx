<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LOGIN.aspx.cs" Inherits="LOGIN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <asp:PlaceHolder runat="server">
        <style type="text/css">
            .login-container {
                width: 100%;
                text-align: center;
                font-family: Times New Roman, sans-serif;
                font-size: 18px;
                color: #000000; /* Text color */
                background-color: black;
                border-radius: 5px; /* Corrected syntax for border-radius */
            }
                    
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
            .login-form {
                width: 50%;
                margin: 0 auto;
                border: 2px solid; /* Corrected syntax for border */
                border-color: black; /* Border color */
                border-radius: 10px;
                padding: 50px;
                /* Background color */
            }
            .login-form h2 {
                font-size: 24px;
                font-weight: bold;
                color: white; /* Header color */
                margin-bottom: 20px;
                font-family: Times New Roman, sans-serif;

            }
            /* ... rest of the styles ... */
        </style>
    </asp:PlaceHolder>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="login-container">
        <div class="login-form">
            <h2>LOGIN FORM</h2>
            <label for="TextBox1">USERNAME</label><br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style37" Height="30px" Width="180px"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*fill it" ControlToValidate="TextBox1"></asp:RequiredFieldValidator><br />

            <label for="TextBox2">PASSWORD</label><br />
            <asp:TextBox ID="TextBox2" runat="server" Height="31px" Width="180px" TextMode="Password"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*fill it" ControlToValidate="TextBox2"></asp:RequiredFieldValidator><br />

            <asp:Button ID="Button1" runat="server" CssClass="submit-button" Height="35px" OnClick="Button1_Click" Text="LOGIN" Width="87px" />
            <asp:Button ID="Button2" runat="server" CssClass="back-button" Height="35px" OnClick="Button2_Click" Text="BACK" Width="61px" />
        </div>
    </div>
</asp:Content>
