<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FacReg.aspx.cs" Inherits="Newproj.faculty.FacReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
    <h1>Faculty Registration</h1>

</head>
<body style="background-color:#d5f4e6;">
    <form id="form1" runat="server" align="left">
        <div><br />
            <asp:Label ID="Label1" runat="server" Text="Name" ></asp:Label>

            <asp:TextBox ID="TextBox1" runat="server" Style="margin-left: 92px" Width="184px"></asp:TextBox><br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your name" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator><br /><br />

            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>

            <asp:TextBox ID="TextBox2" runat="server" TextMode="Email" Style="margin-left: 92px" Width="184px"></asp:TextBox><br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your email" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator><br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid format" ControlToValidate="TextBox2" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator><br />

            <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>

            <asp:TextBox ID="TextBox3" runat="server" TextMode="Phone"  Style="margin-left: 92px" Width="184px"></asp:TextBox><br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your Phone number" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator><br />
            

            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please check your Number" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
            <br />

           <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="gender" Text="Others" /><br /><br />

             <asp:Label ID="Label5" runat="server" Text="Organization"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlcollege" runat="server" style="margin-left: 1px" Width="184px">
                 <asp:ListItem  Text="select" ></asp:ListItem>
                 <asp:ListItem  Text="RIT,KOTTAYAM" ></asp:ListItem>
                   <asp:ListItem  Text="ST PIUS X COLLEGE ,KASARGOD" ></asp:ListItem>
                 <asp:ListItem  Text="ST JOSEPH COLLEGE DEVAGIRI" ></asp:ListItem>
                 <asp:ListItem  Text="CUSAT, KOCHI" ></asp:ListItem>
                

               
            </asp:DropDownList><br />
            <br />


            <asp:Label ID="dob" runat="server" Text="Dob"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="Label7" runat="server" Text="D:"></asp:Label>
            <asp:DropDownList ID="Ddlday" runat="server" style="margin-left: 0px"></asp:DropDownList>
            M:<asp:DropDownList ID="Ddlmonth" runat="server"></asp:DropDownList>
            Y:<asp:DropDownList ID="Ddlyear" runat="server"></asp:DropDownList><br /><br />

            
          
            <asp:Label ID="Label6" runat="server" Text="User Name"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Style="margin-left: 62px" Width="184px"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your Username" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator><br />
            
            <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label>

            <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" Style="margin-left: 74px" Width="184px"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your Password" ControlToValidate="TextBox5" ForeColor="Red"></asp:RequiredFieldValidator><br />
           
           

            Confirm  Password: 
            <asp:TextBox ID="confirmpass" runat="server" Style="margin-left: 13px" Width="184px" TextMode="Password"></asp:TextBox><br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please confirm your Password" ControlToValidate="confirmpass" ForeColor="Red"></asp:RequiredFieldValidator><br />

            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords are not matching" ControlToCompare="TextBox5" ControlToValidate="confirmpass" ForeColor="Red"></asp:CompareValidator><br />
            <asp:Button ID="Button1" runat="server" Text="Register" Height="38px" style="margin-left: 88px" Width="145px" OnClick="Button1_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
