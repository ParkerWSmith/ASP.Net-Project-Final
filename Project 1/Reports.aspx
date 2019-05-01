<%@ Page Language="C#" MasterPageFile="~/Report.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Project_1.Reports" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblReport" runat="server" OnDataBinding="Page_Load" Style="z-index: 1; left: 482px; top: 159px; position: absolute; width: 346px" Text="Report Selection" Font-Size="XX-Large"></asp:Label>
    <asp:Button ID="btnInstitution" runat="server" Style="z-index: 1; left: 466px; top: 221px; position: absolute; height: 41px; width: 250px" Text="Problems By Institution" Font-Bold="True" OnClick="btnInstitution_Click" />
    <asp:Button ID="btnClient" runat="server" Style="z-index: 1; left: 467px; top: 283px; position: absolute; height: 38px; width: 250px" Text="Problems By Client" Font-Bold="True" OnClick="btnClient_Click" />
    <asp:Button ID="btnProduct" runat="server" Style="z-index: 1; left: 469px; top: 347px; position: absolute; width: 248px; height: 38px" Text="Problems By Product" Font-Bold="True" OnClick="btnProduct_Click" />
    <asp:Button ID="btnTech" runat="server" Style="z-index: 1; left: 471px; top: 408px; position: absolute; height: 39px; width: 245px" Text="Problems By Technician" Font-Bold="True" OnClick="btnTech_Click" />
    <asp:Button ID="btnMainMenu" runat="server" Style="z-index: 1; left: 474px; top: 530px; position: absolute; height: 39px; width: 245px" Text="Return to Main Menu" Font-Bold="True" OnClick="btnMainMenu_Click" />
</asp:Content>
