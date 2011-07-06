<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ScriptServiceExample._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    
    <script type="text/javascript">

        function calculate() {
            var num1 = document.getElementById('num1').value;
            var num2 = document.getElementById('num2').value;
            Samples.Services.Calculator.Add(num1, num2, onSuccess, onError);

        }

        function onSuccess(result) {
            document.getElementById('answer').value = result;
        }

        function onError(error) {
            alert(error);
        }
    
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
        <asp:ServiceReference Path="~/Calculator.svc" />
        </Services>
        </asp:ScriptManager>
        Num 1:<input id="num1" type="text" />
        Num 2:<input id="num2" type="text" />
        =
        <input id="answer" type="text" /><input id="Button1" type="button" onclick="javascript:calculate(); return false;" value="Submit" />
    </div>
    </form>
</body>
</html>
