<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Photo2.aspx.cs" Inherits="Photo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 

        <asp:Table runat="server" width="50%" id="textTable">
        <asp:TableRow>
            <asp:TableCell width="40%" id='heading'>
                <strong>Assessor Property Photo</strong>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow />
        <asp:TableRow runat="server">
            <asp:TableCell>
                Tax Parcel Identifer
            </asp:TableCell>
            <asp:TableCell id='featureID'>
                <asp:Label runat="server" ID="lblParcelID"/>

            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server" class="table">
            <asp:TableCell>
                Tax Parcel Address
            </asp:TableCell>
            <asp:TableCell class="table" >
               <asp:Label runat="server" ID="siteAddress"/>
            </asp:TableCell>
        </asp:TableRow>

    </asp:Table>

    <asp:Table ID="tblImages" runat="server">

    </asp:Table>
    </form>
</body>
</html>
