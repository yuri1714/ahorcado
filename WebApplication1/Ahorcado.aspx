<%@ Page Title="ahorcado Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ahorcado.aspx.cs" Inherits="WebApplication1.Ahorcado" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <asp:Label ID="lblPalabraOculta" runat="server" Text="_____"></asp:Label>
        <br />
        <asp:TextBox ID="txtLetra" runat="server" MaxLength="1"></asp:TextBox>
        <asp:Button ID="btnAdivinar" runat="server" Text="Adivinar" OnClick="btnGuess_Click" />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblIntentos" runat="server" Text="Intentos restantes: 6"></asp:Label>
        <br />
        <asp:Panel ID="panelAhoracado" runat="server" CssClass="ahorcado" Visible="true">
            <asp:Label ID="base" runat="server" CssClass="base"></asp:Label>
            <asp:Label ID="posteVertical" runat="server" CssClass="poste-vertical"></asp:Label>
            <asp:Label ID="posteHorizontal" runat="server" CssClass="poste-horizontal"></asp:Label>
            <asp:Label ID="cuerda" runat="server" CssClass="cuerda"></asp:Label>
            <asp:Label ID="cabeza" runat="server" CssClass="cabeza"></asp:Label>
            <asp:Label ID="cuerpo" runat="server" CssClass="cuerpo"></asp:Label>
            <asp:Label ID="brazoIzq" runat="server" CssClass="brazo-izq"></asp:Label>
            <asp:Label ID="brazoDer" runat="server" CssClass="brazo-der"></asp:Label>
            <asp:Label ID="piernaIzq" runat="server" CssClass="pierna-izq"></asp:Label>
            <asp:Label ID="piernaDer" runat="server" CssClass="pierna-der"></asp:Label>
        </asp:Panel>

        <br />
        <asp:Button ID="btnReset" runat="server" Text="Reiniciar" OnClick="btnRestart_Click" />
     </main>
</asp:Content>
