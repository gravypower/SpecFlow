<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Web.Calculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel runat="server" ID="panNumbers">
        First Number: <asp:TextBox runat="server" ID="txtFirstNumber"></asp:TextBox>
        <br/>
        Second Number: <asp:TextBox runat="server" ID="txtSecondNumber"></asp:TextBox>
        <br/>
        Third Number: <asp:TextBox runat="server" ID="txtThirdNumber"></asp:TextBox>
    </asp:Panel>
    <asp:Button runat="server" ID="butAddNumbers" Text="Add Numbers" OnClick="butAddNumbers_Click"/>
    <asp:Label runat="server" ID="lblResult"></asp:Label>
    <asp:Label runat="server" ID="lblErrorMessage"></asp:Label>
</asp:Content>
