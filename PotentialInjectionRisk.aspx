<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PotentialInjectionRisk.aspx.cs" Inherits="PotentialInjectionRisk" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <h1>Kommentteja MySQL-kantaan</h1>
  <p>nimesi:<asp:TextBox ID="txtName" runat="server" Text="..."></asp:TextBox><asp:RegularExpressionValidator runat="server" ControlToValidate="txtName" ErrorMessage="Annettu nimi ei kelpaa" ValidationExpression="^[A-Öa-ö_-´]+$" ForeColor="Maroon"></asp:RegularExpressionValidator></p>
  <p>kommenttisi:<asp:TextBox ID="txtComment" runat="server" Text="..."></asp:TextBox></p>
  <p>tänään on:<asp:TextBox ID="txtDate" runat="server" Enabled="false" Text="..."></asp:TextBox></p>
    <asp:Button runat="server" ID="btn" OnClick="btn_Click" Text="test" />
  <h2>Kommentit</h2>
  <!-- mysql datasources -->
  <asp:SqlDataSource ID="myComments" runat="server" 
    ConnectionString="<%$ ConnectionStrings:Mysli %>" 
    ProviderName="MySql.Data.MySqlClient"
    SelectCommand="SELECT name, comment, date FROM comment" />
  <asp:GridView ID="gvComments" runat="server" DataSourceID ="myComments" />
  <asp:Label ID="lblMessages" Text="..." runat="server" />
</asp:Content>

