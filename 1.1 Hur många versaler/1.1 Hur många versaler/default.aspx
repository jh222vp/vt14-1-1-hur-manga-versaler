<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_1._1_Hur_många_versaler._default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
</head>
<body>
    <h1>Hur många versaler?</h1>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="Input" runat="server" TextMode="MultiLine" Width="258px" Height="49px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server" Visible="false">
                <asp:Button ID="Button2" runat="server" Text="Clear" OnClick="Button2_Click" />
                <p>
                    <asp:Label ID="outMessage" runat="server" Text=""></asp:Label>
                </p>
            </asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
