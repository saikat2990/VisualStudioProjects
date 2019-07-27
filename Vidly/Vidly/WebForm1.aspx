<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Vidly.WebForm11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:<asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            Roll:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            City:<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>London</asp:ListItem>
                <asp:ListItem>Dhaka</asp:ListItem>
                <asp:ListItem>Sydney</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Load" runat="server" Text="load" Width="94px" />
        </div>
        <asp:CheckBox ID="GraduateCheckBox" runat="server" Text="Graduate" TextAlign="Left" /><br/>
        <asp:CheckBox ID="UnderGraduateCheckBox" runat="server" Text="UnderGraduate" /><br/>
        <asp:CheckBox ID="DoctrateCheckBox" runat="server" Text="Doctrate" ToolTip="5" /><br/>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.porn.com/">porn.com</asp:HyperLink>
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" target="_blank" Height="135px" ImageUrl="~/Images/Zeus_Jupiter_Greek_God_Art_06_by_GenzoMan.jpg"
            OnClientClick="alert('You have been warned')" Width="208px" PostBackUrl="https://www.imdb.com/name/nm1411125/" />
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="confirm('Are you confirm')" PostBackUrl="https://www.youtube.com">LinkButton</asp:LinkButton>
        </p>
        <p>
            <asp:Button ID="TopEmployee" runat="server" Text="Top 10 employees" CommandArgument="Top" CommandName="top"  />
            <asp:Button ID="BottomEmployee" runat="server" Text="Bottom 10 employees"  style="height: 26px" CommandArgument="Bottom" CommandName="bottom" />
        </p>
    </form>
</body>
</html>
