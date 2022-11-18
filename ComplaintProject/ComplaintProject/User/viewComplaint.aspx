<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="viewComplaint.aspx.cs" Inherits="ComplaintProject.User.viewComplaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <form id="form1" runat="server">
         <h2>Complaint Details</h2>
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="cmp_id" >
                
            </asp:GridView>
     </form>
</asp:Content>
