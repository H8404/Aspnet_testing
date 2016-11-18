<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
  AutoEventWireup="true" CodeFile="TestaaRoolit.aspx.cs" Inherits="Testi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <div>
    <h3>Autentikoitunut käyttäjä: <asp:Label ID="lblUSername" runat="server" Text="[tähän käyttäjän nimi]"></asp:Label></h3>
    <asp:Button ID="btnShowRoles" runat="server" Text="Näytä kaikki roolit" OnClick="btnShowRoles_Click"/>
    <asp:Button ID="btnShow" runat="server" Text="Näytä käyttäjäryhmäni" OnClick="btnShow_Click"/>
    <h3>Roolit:</h3>
    <asp:Literal ID="ltMessage" runat="server"></asp:Literal>
  </div>
</asp:Content>
