<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirm_faculty.aspx.cs" Inherits="Newproj.admin.confirm_faculty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <h3> Faculty confirmation</h3><br /><br />
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="GridView1" runat="server" DataKeyNames="lid1" OnRowDeleting="GridView1_RowDeleting" >
                <Columns>
                    <asp:CommandField HeaderText="Sts" ShowDeleteButton="True" DeleteText="confirm" />
                </Columns>
                
            </asp:GridView>
    </form>
</body>
</html>
