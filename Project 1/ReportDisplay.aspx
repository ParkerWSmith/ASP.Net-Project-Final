<%@ Page Language="C#" MasterPageFile="~/Report.Master" AutoEventWireup="true" CodeBehind="ReportDisplay.aspx.cs" Inherits="Project_1.ReportDisplay" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 90px; top: 537px; position: absolute; width: 238px" Text="Error"></asp:Label>
    <asp:Label ID="lblReport" runat="server" OnDataBinding="Page_Load" Style="z-index: 1; left: 481px; top: 143px; position: absolute; width: 346px" Text="Report Selection" Font-Size="XX-Large"></asp:Label>
    <asp:Button ID="btnMainMenu" runat="server" Style="z-index: 1; left: 471px; top: 483px; position: absolute; height: 39px; width: 245px" Text="Return to Reports" Font-Bold="True" OnClick="btnMainMenu_Click" />
    <asp:GridView ID="gvData" runat="server" style="z-index: 1; left: 115px; top: 187px; position: absolute; height: 193px; width: 944px" ></asp:GridView>
</asp:Content>
