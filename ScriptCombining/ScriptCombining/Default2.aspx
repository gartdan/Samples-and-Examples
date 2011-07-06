<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="ScriptCombining.Default2" %>
<%@ Register Assembly="ScriptReferenceProfiler" Namespace="ScriptReferenceProfiler"
    TagPrefix="cc2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <asp:ScriptManager ID="ScriptManager1" runat="server">
           <CompositeScript>
            <Scripts>
                <asp:ScriptReference name="MicrosoftAjax.js"/>
	            <asp:ScriptReference name="MicrosoftAjaxWebForms.js"/>
	            <asp:ScriptReference name="AjaxControlToolkit.Common.Common.js" assembly="AjaxControlToolkit, Version=3.0.30930.28736, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"/>
            </Scripts>
            </CompositeScript>
        </asp:ScriptManager>
        
        <asp:TextBox ID="TextBox1" runat="server" />
        <cc2:ScriptReferenceProfiler ID="ScriptReferenceProfiler1" runat="server" />
    </div>
    </form>
</body>
</html>
