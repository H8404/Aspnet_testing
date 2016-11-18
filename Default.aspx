<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
  AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <div>
    <h2>Vaarallisia paikkoja, siirry vain omalla vastuulla <img src="Images/err.PNG" style="width:5%" alt="apuva"/></h2>
    <p>
      <asp:HyperLink ID="HyperLink2" runat="server"
        NavigateUrl="TestaaTunnistus.aspx">Näytä käyttäjätiedot</asp:HyperLink><br />
      <asp:HyperLink ID="HyperLink3" runat="server"
        NavigateUrl="~/ValidateRequest.aspx">Request Validation Testi</asp:HyperLink><br />
      <asp:HyperLink ID="HyperLink5" runat="server"
        NavigateUrl="~/PotentialInjectionRisk.aspx">Testaa SQL Injection Mitigating</asp:HyperLink><br />
      <asp:HyperLink ID="HyperLink4" runat="server"
        NavigateUrl="~/TestaaMD5hash.aspx">Testaa MD5 hash</asp:HyperLink><br />
      <asp:HyperLink ID="HyperLink1" runat="server"
        NavigateUrl="TestaaRoolit.aspx">Näytä käyttäjän nimi ja rooli</asp:HyperLink><br />
    </p>
  </div>

</asp:Content>

