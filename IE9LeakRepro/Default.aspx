<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="IE9LeakRepro._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript" src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.6.1.min.js"></script>
</head>
<body>
    <form id="Form1" runat="server">
<asp:ScriptManager ID="scriptManager" runat="server">
<Services>
    <asp:ServiceReference Path="~/Services/UpdateService.svc" />
</Services>
</asp:ScriptManager>

<script type="text/javascript">
    this.interval = null;
    this.timer = null;

    function pageLoad() {
        this.interval = 1000;
        setInterval(pollUsingjQuery, this.interval);
    }

    function poll() {
        var successFunc = Function.createDelegate(this, this.OnUpdateResponseComplete);
        var errorFunc = Function.createDelegate(this, this.OnUpdateResponseError);
        UpdateService.GetGraphicUpdates(successFunc, errorFunc);
    }

    var serviceUri = "http://localhost:41200/Services/UpdateService.svc/GetGraphicUpdates";
    var successFunc = Function.createDelegate(this, this.OnUpdateResponseComplete);
    var errorFunc = Function.createDelegate(this, this.OnUpdateResponseError);

    function pollUsingjQuery() {

        var xhr = $.post(serviceUri).success(successFunc).error(errorFunc);
        xhr = null;
        CollectGarbage();
    }

    function OnUpdateResponseComplete(response, applyUpdatesMethod) {
        response.Updates = null;
        response = null;
        delete response;
    }

    function OnUpdateResponseError(error, context, method) {
        alert('Error.' + error);
    }

    window.onload = pageLoad;

</script>
    <h2>
       IE9 -Memory Leak Test
    </h2>
    <p>
        Calling JSON Service UpdateService.svc
    </p>
    <p>
        Repro for an IE9 Memory Leak. Set the interval variable to configure the frequency of calls to the JSON sevice.
        Memory increases over time and is never reclaimed, eventually causing OOM exceptions.
    </p>
        </form>
</body>
</html>