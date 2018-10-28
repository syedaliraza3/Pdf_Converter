<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 454px;
            width: 100px;
        }
        .heading {
            font-size:28px;
        }
        .convertBtn {
            border-radius:7px;
            background-color:green;
            color:white;
        }
        .dataPanel {
            border:5px solid;
        }
        .auto-style3 {
            height: 454px;
            width: 185px;
        }
        .auto-style4 {
            width: 46%;
            height: 555px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style4">
                <tr>
                    <td class="auto-style3">
                        <asp:Label CssClass="heading" ID="panelAHeading" runat="server" Text="Panel A"></asp:Label>
                        <br />
                        <asp:Label ID="panelADescription" runat="server" Text="Source Files"></asp:Label>
                        <asp:Panel ID="sourcePanel" CssClass="dataPanel" runat="server" Height="453px">             
                            <asp:ListView ID="sourceList" runat="server">
                                <ItemTemplate>
                                    <%# Container.DataItem %>
                                </ItemTemplate>
                                <ItemSeparatorTemplate>
                                    <br />
                                </ItemSeparatorTemplate>
                            </asp:ListView>
                        </asp:Panel>
                    </td>
                    <td class="auto-style2">
                        <div align="center">
                            <asp:Button CssClass="convertBtn" ID="convertToPDF" runat="server" Text="Convert >" OnClick="convertToPDF_Click" Height="37px" Width="92px" />
                        </div>
                    </td>
                    <td class="auto-style3">
                        <asp:Label CssClass="heading" ID="panelBHeading" runat="server" Text="Panel B"></asp:Label>
                        <br />
                        <asp:Label ID="panelBDescription" runat="server" Text="Destination Files"></asp:Label>
                        <asp:Panel ID="desinationPanel" CssClass="dataPanel" runat="server" Height="453px">
                            <asp:ListView ID="destinationList" runat="server">
                                <ItemTemplate>
                                    <%# Container.DataItem %>
                                </ItemTemplate>
                                <ItemSeparatorTemplate>
                                    <br />
                                </ItemSeparatorTemplate>
                            </asp:ListView>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
