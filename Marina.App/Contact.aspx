<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Marina.App.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="container" style="margin-top:70px;">
        <h3>Contact Information: </h3>
        <address>
            Inland Lake Marina <br />
            Box 123 <br />
            Inland Lake, Arizona <br />
            86038 <br />
            <abbr title="OfficePhone">office ph: </abbr>
             928-555-2234 <br/>
            <abbr title="LeasingPhone">Leasing Ph: </abbr>
             928-555-2234 <br/>
            <abbr title="Fax">Fax: </abbr>
              928-555-2236 <br/>
        </address>
        <strong>Manager: </strong> Glenn Cooke <br />
        <strong>Slip Manager: </strong>  Kimberley Carson <br />
        <address>
            <strong>Support:</strong><a href="mailto:info@inlandmarina.com">info@inlandmarina.com</a><br />
        </address>
    </div>
    
</asp:Content>