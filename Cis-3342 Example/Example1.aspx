<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Example1.aspx.cs" Inherits="Cis_3342_Example.Example1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script  type="text/javascript" lang="javascript">
        function validate(flag)
        {

            if (flag == 1)
            {
                document.getElementById("hiden").value = "jiafa";
            }
            else if(flag == 2)
            {
                document.getElementById("hiden").value = "jianfa";
            }
            else if(flag == 3)
            {
                document.getElementById("hiden").value = "chengfa";
            }
            else if(flag == 4)
            {
                document.getElementById("hiden").value = "chufa";
            }
            document.getElementById("form1").submit();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        
        <br/>

        <asp:TextBox id="txt1" runat="server"></asp:TextBox><br/>

        <asp:TextBox id="txt2" runat="server"></asp:TextBox><br/>
        <input type="button" id="btn1" value=" 加法" onclick="validate(1)"/><br />
        <input type="button" id="btn2" value="减法" onclick="validate(2)"/><br />
        <input type="button" id="btn3" value="乘法" onclick="validate(3)"/><br />
        <input type="button" id="btn4" value="除法" onclick="validate(4)"/><br />
        <input type="hidden" id="hiden" name="hiden" />

        <br />
        <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
        <br />

    </form>

</body>
    
</html>
