<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Marina.App.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin-top:100px;">
        <table class="table">
            <tr>
                <td style="width:150px">First Name</td>
                <td>
                    <asp:TextBox ID="uxFirstName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Last Name:</td>
                <td>
                    <asp:TextBox ID="uxLastName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Phone:</td>
                <td>
                    <asp:TextBox ID="uxPhone" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>City:</td>
                <td>
                    <asp:TextBox ID="uxCity" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-primary" OnClick="btnSubmit_Click"/>
    </div>
</asp:Content>
