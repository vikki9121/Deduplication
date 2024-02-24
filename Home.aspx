<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>
   
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <meta name="keywords" content="" />
    <meta name="description" content="" />
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <title>Updated Design</title>
    <link href="http://fonts.googleapis.com/css?family=Abel" rel="stylesheet" type="text/css" />
    <link href="style.css" rel="stylesheet" type="text/css" media="screen" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
    <script type="text/javascript" src="jquery.dropotron-1.0.js"></script>
    <%--<link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" />--%>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" />
  
    <style type="text/css">
        .auto-style2 {
            height: 20%;
            width: 976px;
            color:white;
            background-color : black;
            
            
        }
        .auto-style5 {
            height: 293px;

        }
        .auto-style6 {
            width: 100%;
            
            
        }
       
        .auto-style8 {
            width: 50px;
           
        }
        .auto-style9 {
            width: 133px;
        }
        .auto-style10 {
            width: 100%;
            text-align: center;
        }
        .auto-style11 {
            width: 250px;
            margin: 0 auto;
        }
        .auto-style12 {
            width: 250px;
        }
        body{
            background-image:url(images/main.jpg);
            background-position:center;
            background-size:cover;
            background-attachment:fixed;
        }
        /* New styles */
        .btn-custom {
            background-color: black; /* Blue */
            border:double;
            color: white;
            padding: 20px 20px;
            width: 25%;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            
            cursor: pointer;
            border-radius: 5px;
        }
        .btn-custom:hover {
            background-color: dimgray; 
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div id="wrapper">
            <div id="header-wrapper">
                <div id="header" class="auto-style6" >
                    
                    <br />
                    <br />           
                    <h1 class="auto-style2">DATA DEDUPLICATION</h1>
                </div>    
            </div>
        </div>

        <div id="page">
            <table class="auto-style6">
                <tr>
                    <td colspan="5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style7" colspan="3">
                        
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style10" colspan="3">
                        <br />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" CssClass="btn-custom animate__animated animate__bounce" Text="LOGIN" />
                        <br />
                        <br />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" CssClass="btn-custom animate__animated animate__bounce" Text="REGISTER" />
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
