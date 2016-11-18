<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HandleValidationError.aspx.cs" Inherits="HandleValidationError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Validation Error in page</title>
  <script>
    function goBack() {
      window.history.back()
    }
  </script>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <h1>Käyttäjän syöte ei ole kelvollinen / User input is not valid.</h1>
      <img src="Images/err.png" alt="error" />
      <p>Syötteesi ei ollut validi, tarkista se!</p>
      <a href="#" onclick="goBack()">takaisin / back</a>
    </div>
  </form>
</body>
</html>
