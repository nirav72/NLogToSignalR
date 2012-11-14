﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NLog.Targets.SignalR.AspNetServer.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="content/toastr.css" rel="stylesheet"/>
    <script src="Scripts/jquery-1.6.4.js" type="text/javascript"></script>
    <script src="Scripts/jquery.signalR-0.5.3.js" type="text/javascript"></script>
    <script src="Scripts/toastr.js" type="text/javascript"></script>
    <script src='<%=ResolveClientUrl("~/signalr/hubs") %>' type="text/javascript"></script>
    <script src="SignalR.MessengerHub/SignalR.MessengerHub.js" type="text/javascript"></script>
</head>
<body>
    <div id="container">
    </div>
</body>
</html>