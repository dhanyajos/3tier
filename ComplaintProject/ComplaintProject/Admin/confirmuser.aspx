<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="confirmuser.aspx.cs" Inherits="ComplaintProject.Admin.confirmuser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">

    <h2>User Details</h2>
          
 <form id="form1" runat="server">
         
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="lid1" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:CommandField HeaderText="Sts" ShowDeleteButton="True" DeleteText="confirm" />
                </Columns>
            </asp:GridView>
     </form>
   
 </asp:Content>
