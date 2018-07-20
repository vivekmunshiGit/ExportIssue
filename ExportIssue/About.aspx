<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ExportIssue.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Button id="exportExcel" runat="server" Text="Export" OnClick="exportExcel_Click"/>
      <asp:Button id="enableButton" runat="server" Text="Enable Me!" Enabled="false"/>
</asp:Content>
