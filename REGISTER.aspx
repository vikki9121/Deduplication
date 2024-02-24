<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="REGISTER.aspx.cs" Inherits="REGISTER" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        body {
            background-color: #f5f5f5; /* Background color for the entire page */
            font-family: Arial, sans-serif; /* Font family for text */
            font-size: 16px; /* Base font size */
            color: #333; /* Text color */
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
        .register-container {
            width: 100%;
            margin: 0 auto;
            padding-top: 50px; /* Top padding for spacing */
            text-align: center; /* Center align content */
        }
        .register-form {
            width: 60%;
            margin: 0 auto;
            background-color: #fff; /* Background color for the form */
            border-radius: 10px; /* Rounded corners */
            padding: 30px; /* Padding inside the form */
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); /* Box shadow for a slight depth effect */
        }
        .register-form h2 {
            font-size: 24px; /* Header font size */
            font-weight: bold; /* Header font weight */
            color: #428bca; /* Header color */
            margin-bottom: 20px; /* Bottom margin for spacing */
        }
        .register-form label {
            font-weight: bold; /* Label font weight */
            color: #555; /* Label color */
        }
        .register-form input[type="text"],
        .register-form input[type="password"],
        .register-form select {
            width: 100%; /* Full width for input fields */
            height: 40px; /* Input height */
            margin-bottom: 20px; /* Bottom margin for spacing */
            padding: 10px; /* Padding inside input fields */
            border: 1px solid #ccc; /* Input border color */
            border-radius: 5px; /* Rounded corners */
            font-weight: bold; /* Input font weight */
            color: #555; /* Input text color */
        }
        .register-form .submit-button,
        .register-form .back-button {
            width: 150px; /* Button width */
            height: 40px; /* Button height */
            background-color: #ff6f61; /* Button background color */
            color: #fff; /* Button text color */
            border: none; /* Remove button border */
            border-radius: 20px; /* Rounded corners */
            cursor: pointer; /* Add pointer cursor on hover */
            font-weight: bold; /* Button font weight */
            margin-right: 10px; /* Right margin for spacing */
        }
        .register-form .back-button {
            background-color: #6eb5ff; /* Back button background color */
        }
        .register-form .submit-button:hover,
        .register-form .back-button:hover {
            background-color: #ff2e30; /* Darker button color on hover */
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="register-container">
        <div class="register-form">
            <h2>REGISTER NOW !!</h2>
            <label for="TextBox1">Name</label><br />
            <asp:TextBox ID="TextBox1" runat="server" Height="40px" Width="100%"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*fill it"></asp:RequiredFieldValidator><br />

            <label for="TextBox2">Email ID</label><br />
            <asp:TextBox ID="TextBox2" runat="server" Height="40px" Width="100%"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*fill it"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Enter correct email id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator><br />

            <label for="TextBox3">Mobile NO</label><br />
            <asp:TextBox ID="TextBox3" runat="server" Height="40px" Width="100%"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox3" ErrorMessage="*Fill it"></asp:RequiredFieldValidator><br />

            <label for="TextBox4">UserName</label><br />
            <asp:TextBox ID="TextBox4" runat="server" Height="40px" Width="100%"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="*fill it"></asp:RequiredFieldValidator><br />

            <label for="TextBox5">Password</label><br />
            <asp:TextBox ID="TextBox5" runat="server" Height="40px" Width="100%" TextMode="Password"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="*fill it"></asp:RequiredFieldValidator><br />

            <label for="DropDownList1">UserType</label><br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="40px" Width="100%">
                <asp:ListItem>select type</asp:ListItem>
                <asp:ListItem>Customer</asp:ListItem>
                <asp:ListItem>Data Owner</asp:ListItem>
            </asp:DropDownList><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*fill it" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator><br />

            <asp:Button ID="Button1" runat="server" CssClass="submit-button" Height="32px" OnClick="Button1_Click" Text="REGISTER" />
            <asp:Button ID="Button2" runat="server" CssClass="back-button" OnClick="Button2_Click" Text="BACK" Width="64px" />
        </div>
    </div>
</asp:Content>
