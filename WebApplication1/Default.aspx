<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>



        <div class="row">
            <div>
                <h2>Inicio de sesión</h2>
                <asp:Label ID="LblMessage" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <asp:Label ID="LblUsername" runat="server" Text="Usuario: "></asp:Label>
                <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername"
                    ErrorMessage="El usuario es obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                <br /><br />

                <asp:Label ID="lblPassword" runat="server" Text="Contraseña: "></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                    ErrorMessage="La contraseña es obligatoria" ForeColor="Red"></asp:RequiredFieldValidator>
                <br /><br />

                <asp:Button ID="BtnLogin" runat="server" Text="Iniciar Sesión" OnClick="BtnLogin_Click" />
            </div>

        </div>
    </main>

</asp:Content>
