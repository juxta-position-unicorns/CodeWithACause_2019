<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportTemplate.aspx.cs" Inherits="StlCollegePrepWebsite.Views.Report.ReportTemplate" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Report Template</title>
    </head>
    <body style="margin: 0px; padding: 0px;">
        <form id="form2" runat="server">
            <div>
                <div runat="server" id="errorMessage" class="text-warning" />
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                    <Scripts>
                        <asp:ScriptReference Assembly="ReportViewerForMvc" Name="ReportViewerForMvc.Scripts.PostMessage.js" />
                    </Scripts>
                </asp:ScriptManager>
                <rsweb:ReportViewer 
                    ID="rvSiteMapping" 
                    runat="server"
                    Width="100%" 
                    Height="100%"
                    AsyncRendering="true" 
                    ZoomMode="Percent" 
                    KeepSessionAlive="true" 
                    SizeToReportContent="false">
                </rsweb:ReportViewer>
            </div>
        </form>
    </body>
</html>