<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ticketlenadena.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="Twittwerbutton" OnClick="Twittwerbutton_Click" Text="Post To Twitter!!" />
    <asp:Button runat="server" ID="FacebookButton" OnClick="FacebookButton_Click" Text="Post To Facebook!!" />
</asp:Content>
