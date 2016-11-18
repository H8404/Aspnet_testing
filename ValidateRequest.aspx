<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ValidateRequest.aspx.cs" Inherits="ValidateRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <h1>Request validation in ASP.NET</h1>
  <p>Request validation is a feature in ASP.NET that examines an HTTP request and determines whether it contains potentially dangerous content. In this context, potentially dangerous content is any HTML markup or JavaScript code in the body, header, query string, or cookies of the request. ASP.NET performs this check because markup or code in the URL query string, cookies, or posted form values might have been added for malicious purposes.</p>
  <h2>Test Request validation</h2>
  <div>
    Kirjoita tähän kommenttisi:
    <br />
    nimi:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    kommentti<asp:TextBox ID="txtComment" runat="server"></asp:TextBox>
      <asp:RegularExpressionValidator ID="myValidator" runat="server" ErrorMessage="Nimessä ei voi olla erikoismerkkejä" ControlToValidate="txtName" ValidationExpression="^[A-Öa-ö_-]+$" ForeColor="Red"></asp:RegularExpressionValidator>
    <asp:Button ID="btnCommit" runat="server" Text="Kommitoi kommenttini" OnClick="btnCommit_Click" />
  </div>
  <asp:Literal ID="ltMessage" runat="server" text="..."/>
  <h3>Vierailijoitten kommentit</h3>
  <asp:XmlDataSource ID="mySource" runat="server" DataFile="~/App_Data/Comments.xml" EnableCaching="False" />
  <div>
    <asp:GridView ID="gvComments" runat="server" DataSourceID="mySource" />
  </div>
</asp:Content>

