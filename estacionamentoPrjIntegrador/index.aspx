<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="estacionamentoPrjIntegrador.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="/estilo/moda.css" rel="stylesheet" />
    <title>Estacionamento SENAC</title>
</head>
<body>
    <form id="form" runat="server">
        <%-------------------------------------------------------------------------------------%>
        <div id="Logo">
            <h1>Estacionamento Senac</h1>
             <img src="/foto/carro.png" alt="Logo" />
        </div>
        <%-------------------------------------------------------------------------------------%>
        <div>
            <div id="Login">
                <h2>Painel de Acesso</h2>
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Digite seu Login"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" placeholder=" Digite sua Senha "></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Acessar" />
                <asp:LinkButton ID="LinkButton1" runat="server">Esqueci a Senha</asp:LinkButton>
            </div>
            <%-------------------------------------------------------------------------------------%>
            <div id="EsqueciASenha">
                <h2>Atualizar Senha</h2>
                <asp:TextBox ID="TextBox7" runat="server" placeholder="Digite seu Login"></asp:TextBox>
                <asp:TextBox ID="TextBox8" runat="server" placeholder=" Nova Senha "></asp:TextBox>
                <asp:Button ID="Button7" runat="server" Text="Trocar" />
            </div>
            <%-------------------------------------------------------------------------------------%>
            <div id="ChamaLogin">
                <asp:LinkButton ID="LinkButton2" runat="server">Acessar</asp:LinkButton>
                <asp:LinkButton ID="LinkButton3" runat="server">Cadastrar</asp:LinkButton>
            </div>
            <%-------------------------------------------------------------------------------------%>
            <div id="Cliente">
                <h2>Cadastro de Cliente</h2>
                 <asp:TextBox ID="TextBox3" runat="server" placeholder="Digite seu Login"></asp:TextBox>
                <asp:TextBox ID="TextBox4" runat="server" placeholder=" Digite sua Senha "></asp:TextBox>
                 <asp:TextBox ID="TextBox5" runat="server" placeholder="Digite seu Nome"></asp:TextBox>
                <asp:TextBox ID="TextBox6" runat="server" placeholder=" Digite sua Placa "></asp:TextBox>
                <asp:Button ID="CadastroCliente" runat="server" Text="Cadastrar" OnClick="CadastroCliente_Click" />
            </div>
            <%-------------------------------------------------------------------------------------%>
            <div id="Vaga">
                <asp:Button ID="Button8" runat="server" Text="Escolher Vaga" />
                <img src="/foto/vaga.png" alt="vaga" />               
            </div>
            <%-------------------------------------------------------------------------------------%>
            <div id="Pagamento">
                <h2>Pagamento</h2>
                             <%------------- --------------------------------%>
                <div id="Informacao">
                    <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text="LabelNome"></asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="Placa:"></asp:Label>
                    <asp:Label ID="Label4" runat="server" Text="LabelPlaca"></asp:Label>
                    <asp:Label ID="Label5" runat="server" Text="Valor:"></asp:Label>
                    <asp:Label ID="Label6" runat="server" Text="LabelValor"></asp:Label>
                    <asp:Label ID="Label7" runat="server" Text="Tempo:"></asp:Label>
                    <asp:Label ID="Label8" runat="server" Text="Entrada"></asp:Label>
                    <asp:Label ID="Label10" runat="server" Text="Saída"></asp:Label>
                </div>       
                          <%--------------------------------------------------%>
                <div id="FormasPag">
                    <asp:Button ID="Button2" runat="server" Text="Dinehiro" />
                    <asp:Button ID="Button3" runat="server" Text="PIX" />
                    <asp:Button ID="Button4" runat="server" Text="Débito" />
                    <asp:Button ID="Button5" runat="server" Text="Crédito" />
                    <asp:DropDownList ID="ddlBandeira" runat="server">
                        <asp:ListItem Value="MC">MasterCard</asp:ListItem>
                        <asp:ListItem Value="VS">Visa</asp:ListItem>
                        <asp:ListItem Value="EL">Elo</asp:ListItem>
                        <asp:ListItem Value="AE">American Express</asp:ListItem>
                        <asp:ListItem Value="HC">HiperCard</asp:ListItem>
                        <asp:ListItem Value="AL">Alelo</asp:ListItem>
                    </asp:DropDownList>
                </div>
             <%-------------------------------------------------------------------------------------%>
            </div>
        </div>
        <%-------------------------------------------------------------------------------------%>
        <script src="/JavaScript/JavaScript.js"></script>
    </form>
</body>
</html>
