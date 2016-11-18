<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TestaaMD5hash.aspx.cs" Inherits="MD5hash" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <h1>MD5 & SHA256 hash -testausta</h1>
  <p>Käyttäjät XML-tiedostossa<asp:Literal ID="ltFileName" runat="server" /></p>
  <p><asp:Button ID="btnShowUsers" runat="server" OnClick="btnShowUsers_Click" Text="Näytä käyttäjät" /></p>
  <p><asp:ListBox ID="lstUsers" runat="server"></asp:ListBox></p>
  <h3>Käyttäjätunnus:</h3>
  <p>
    Käyttäjätunnus: <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br/>
    Etunimi:<asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox><br/>
    Sukunimi:<asp:TextBox ID="txtLastname" runat="server"></asp:TextBox><br/>
    Salasana:<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
    <asp:Button ID="btnCreateHash" runat="server" Text="Hashaa passu" OnClick="btnCreateHash_Click" />
    hash:
    <asp:TextBox ID="txtPasswordHashed" runat="server" Enabled="true" Width="300" />
    <asp:Button ID="btnCreateUser" runat="server" Enabled="false" Text="Tallenna käyttäjä XML:ään" OnClick ="btnCreateUser_Click" /><br/>
  </p>
  <p>
    <asp:Button ID="btnShowHex" runat="server" Text="Näytä hexana" Enabled="true" OnClick="btnShowHex_Click" />
    <asp:Button ID="btnShowHash" runat="server" Text="Näytä MD5 hash" Enabled="false" OnClick="btnShowHash_Click" />
    <asp:Button ID="btnShowHash256" runat="server" Text="Näytä SHA256 hash" Enabled="false" OnClick="btnShowHash256_Click" />
    <asp:Button ID="btnTesthash" runat="server" Text="Testaa MD5 autentikointi" Enabled="false"  OnClick="btnTesthash_Click" />
    <asp:Button ID="btnTesthash256" runat="server" Text="Testaa SHA256 autentikointi" Enabled="false" OnClick="btnTesthash_Click" />
  </p>
  <p><asp:Label ID="lblResult" runat="server"></asp:Label></p> 
</asp:Content>

