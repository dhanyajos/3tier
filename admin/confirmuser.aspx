﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirmuser.aspx.cs" Inherits="Newproj.admin.confirmuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <h3> Student confirmation</h3><br /><br />
</head>
<body>
    <form id="form1" runat="server">
          <div>
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="lid1" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:CommandField HeaderText="Sts" ShowDeleteButton="True" DeleteText="confirm" />
                </Columns>
                
            </asp:GridView>
    </form>
</body>
</html>
