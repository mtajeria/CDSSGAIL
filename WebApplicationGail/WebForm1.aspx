<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationGail.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 406px">


    <form id="form1" runat="server">
        <h2>MODELO DE GAIL</h2>
        <h2>Cálculo de riesgo de cáncer de mama </h2>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Edad"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" style="margin-left: 403px">
            <%--<asp:ListItem Value="Desconocido"></asp:ListItem>--%>
            <asp:ListItem Value="25"></asp:ListItem>
            <asp:ListItem Value="26"></asp:ListItem>
            <asp:ListItem Value="27"></asp:ListItem>
            <asp:ListItem Value="28"></asp:ListItem>
            <asp:ListItem Value="29"></asp:ListItem>
            <asp:ListItem Value="30"></asp:ListItem>
            <asp:ListItem Value="31"></asp:ListItem>
            <asp:ListItem Value="32"></asp:ListItem>
            <asp:ListItem Value="33"></asp:ListItem>
            <asp:ListItem Value="34"></asp:ListItem>
            <asp:ListItem Value="35"></asp:ListItem>
            <asp:ListItem Value="36"></asp:ListItem>
            <asp:ListItem Value="37"></asp:ListItem>
            <asp:ListItem Value="38"></asp:ListItem>
            <asp:ListItem Value="39"></asp:ListItem>
            <asp:ListItem Value="40"></asp:ListItem>
            <asp:ListItem Value="41"></asp:ListItem>
            <asp:ListItem Value="42"></asp:ListItem>
            <asp:ListItem Value="43"></asp:ListItem>
            <asp:ListItem Value="44"></asp:ListItem>
            <asp:ListItem Value="45"></asp:ListItem>
            <asp:ListItem Value="46"></asp:ListItem>
            <asp:ListItem Value="47"></asp:ListItem>
            <asp:ListItem Value="48"></asp:ListItem>
            <asp:ListItem Value="49"></asp:ListItem>
            <asp:ListItem Value="50"></asp:ListItem>
            <asp:ListItem Value="51"></asp:ListItem>   
            <asp:ListItem Value="52"></asp:ListItem>
            <asp:ListItem Value="53"></asp:ListItem>
            <asp:ListItem Value="54"></asp:ListItem>
            <asp:ListItem Value="55"></asp:ListItem>
            <asp:ListItem Value="56"></asp:ListItem>
            <asp:ListItem Value="57"></asp:ListItem>
            <asp:ListItem Value="58"></asp:ListItem>
            <asp:ListItem Value="59"></asp:ListItem>
            <asp:ListItem Value="60"></asp:ListItem>
            <asp:ListItem Value="61"></asp:ListItem>
            <asp:ListItem Value="62"></asp:ListItem>
            <asp:ListItem Value="63"></asp:ListItem>
            <asp:ListItem Value="64"></asp:ListItem>
            <asp:ListItem Value="65"></asp:ListItem>
            <asp:ListItem Value="66"></asp:ListItem>
            <asp:ListItem Value="67"></asp:ListItem>
            <asp:ListItem Value="68"></asp:ListItem>
            <asp:ListItem Value="69"></asp:ListItem>
            <asp:ListItem Value="70"></asp:ListItem>
            <asp:ListItem Value="71"></asp:ListItem>
            <asp:ListItem Value="72"></asp:ListItem>
            <asp:ListItem Value="73"></asp:ListItem> 
            <asp:ListItem Value="74"></asp:ListItem>
            <asp:ListItem Value="75"></asp:ListItem>
            <asp:ListItem Value="76"></asp:ListItem>
            <asp:ListItem Value="77"></asp:ListItem>
            <asp:ListItem Value="78"></asp:ListItem>
            <asp:ListItem Value="79"></asp:ListItem>
            <asp:ListItem Value="80"></asp:ListItem>      
        </asp:DropDownList>

        <%--<asp:ListItem Value="Desconocido"></asp:ListItem>--%>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Edad menarca"></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server" style="margin-left: 343px">
            <asp:ListItem Value="7 a 11"></asp:ListItem>
            <asp:ListItem Value="12 a 13"></asp:ListItem>
            <asp:ListItem Value="14 o mayor"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Edad de primer parto"></asp:Label>            
        <asp:DropDownList ID="DropDownList4" runat="server" style="margin-left: 299px">
            <%-- <asp:ListItem Value="Sin partos"></asp:ListItem> --%>
            <asp:ListItem Value="Sin partos"></asp:ListItem>
            <asp:ListItem Value="Menor a 20"></asp:ListItem>
            <asp:ListItem Value="De 20 a 24"></asp:ListItem>
            <asp:ListItem Value="De 25 a 29"></asp:ListItem>
            <asp:ListItem Value="Mayor a 30"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Cantidad de parientes de primer grado con cáncer de mama"></asp:Label>            
        <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 55px">
            <%--<asp:ListItem Value="Desconocido"></asp:ListItem>--%>
            <asp:ListItem Value="0"></asp:ListItem>
            <asp:ListItem Value="1"></asp:ListItem>
            <asp:ListItem Value="Mayor que 1"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Cantidad de biopsias de mama"></asp:Label>            
        <asp:DropDownList ID="DropDownList5" runat="server" style="margin-left: 238px">
            <%--<asp:ListItem Value="Desconocido"></asp:ListItem>--%>
            <asp:ListItem Value="0"></asp:ListItem>
            <asp:ListItem Value="1"></asp:ListItem>
            <asp:ListItem Value="Mayor que 1"></asp:ListItem>
        </asp:DropDownList>
                <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Detección de hiperplasias atípicas"></asp:Label>            
        <asp:DropDownList ID="DropDownList6" runat="server" style="margin-left: 215px">
            <%--<asp:ListItem Value="Desconocido"></asp:ListItem>--%>
            <asp:ListItem Value="No"></asp:ListItem>
            <asp:ListItem Value="Sí"></asp:ListItem>
        </asp:DropDownList>                          
        <br />
        <br />                          
            <p>
            <asp:Button ID="Button1" runat="server" Text="Calcular riesgo" Height="23px" OnClick="Button1_Click" Width="167px" />          
        </p>          
                <asp:Label ID="Label7" runat="server" Text="Probabilidad a 5 años"></asp:Label>
        *<p>
            <asp:Label ID="Lblresult" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="Lblmsg" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Lblacl" runat="server" Font-Size="Small" Text="* Una probabilidad mayor a 1,67% es indicador de riesgo alto"></asp:Label>
        </p>
           
    </form>

</body>
</html>
