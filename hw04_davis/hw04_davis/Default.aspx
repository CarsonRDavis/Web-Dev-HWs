<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="hw04_davis.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HW04 - Carson Davis</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>HW04 - Carson Davis</h2>
            <a href="timeLog.aspx">Time Log</a>
            <p>
                <input type="text" id="equation" />
                <button type="button" id="btnClickMe" onclick="print(equation.value)">Click Me</button>
            </p>
            <p><textarea rows="6" cols="30" id="txaDisplay"></textarea></p>
        </div>
    </form>
    <script>
        function print(equation) {
            var request = new XMLHttpRequest();

            request.open('GET', 'information.aspx?q=' + equation, true);

            request.onreadystatechange = function () {
                document.getElementById("txaDisplay").value = request.responseText;
            }

            request.send();

            document.getElementById("equation").value = "";
        }
    </script>
</body>
</html>
