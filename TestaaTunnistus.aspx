<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TestaaTunnistus.aspx.cs" Inherits="TestaaTunnistus" %>

<%@ Register src="Tunnistus.ascx" tagname="Tunnistus" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:Tunnistus ID="Tunnistus1" runat="server" />
</asp:Content>

