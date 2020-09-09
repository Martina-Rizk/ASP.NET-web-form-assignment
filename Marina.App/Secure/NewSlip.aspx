<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewSlip.aspx.cs" Inherits="Marina.App.NewSlip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin-top:100px;">
        <h3>Available Slips</h3>
        <br />
        <asp:DropDownList ID="ddDocks" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddDocks_SelectedIndexChanged" Width="143px"></asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="grdSlip" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="320px" OnSelectedIndexChanged="grdSlip_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Lease" ShowHeader="True" Text="Lease" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
    </div>
</asp:Content>
