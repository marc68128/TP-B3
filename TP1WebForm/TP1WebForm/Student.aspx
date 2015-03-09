<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="TP1WebForm.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        IdBooster : 
        <input type="number" runat="server" id="IdBooster"/>
        <br/>
        
        FirstName : 
        <input type="text" runat="server" id="FirstName"/>
        <br/>
        
        LastName : 
        <input type="text" runat="server" id="LastName"/>
        <br/>
        
        <input type="submit" value="send"/>
    </div>
    </form>
</body>
</html>
