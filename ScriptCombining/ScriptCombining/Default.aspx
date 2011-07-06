<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ScriptCombining._Default" %>

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
	<asp:ScriptReference name="AjaxControlToolkit.Common.DateTime.js" assembly="AjaxControlToolkit, Version=3.0.30930.28736, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"/>
	<asp:ScriptReference name="AjaxControlToolkit.Compat.Timer.Timer.js" assembly="AjaxControlToolkit, Version=3.0.30930.28736, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"/>
	<asp:ScriptReference name="AjaxControlToolkit.Animation.Animations.js" assembly="AjaxControlToolkit, Version=3.0.30930.28736, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"/>
	<asp:ScriptReference name="AjaxControlToolkit.ExtenderBase.BaseScripts.js" assembly="AjaxControlToolkit, Version=3.0.30930.28736, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"/>
	<asp:ScriptReference name="AjaxControlToolkit.Animation.AnimationBehavior.js" assembly="AjaxControlToolkit, Version=3.0.30930.28736, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"/>
	<asp:ScriptReference name="AjaxControlToolkit.PopupExtender.PopupBehavior.js" assembly="AjaxControlToolkit, Version=3.0.30930.28736, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"/>
	<asp:ScriptReference name="AjaxControlToolkit.Common.Threading.js" assembly="AjaxControlToolkit, Version=3.0.30930.28736, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"/>
	<asp:ScriptReference name="AjaxControlToolkit.Calendar.CalendarBehavior.js" assembly="AjaxControlToolkit, Version=3.0.30930.28736, Culture=neutral, PublicKeyToken=28f01b0e84b6d53e"/>


</Scripts>
</CompositeScript>
        </asp:ScriptManager>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><cc1:CalendarExtender TargetControlID="TextBox1" ID="CalendarExtender1"
            runat="server">
        </cc1:CalendarExtender>
        <cc2:ScriptReferenceProfiler ID="ScriptReferenceProfiler1" runat="server" />
    </div>
    </form>
</body>
</html>
