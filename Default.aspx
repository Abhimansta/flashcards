<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="projectstyle.css" type="text/css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server">
        
        <asp:TextBox runat="server" ID="TeamName" MaxLength="20" Width="200px" Text="Team Name"></asp:TextBox>
        <br /><br />
        <asp:Label runat="server" ID="rolls">Roll Number</asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox runat="server" ID="Member1" MaxLength="20" Width="200px"  Text="Roll Number: Member 1"></asp:TextBox>
        <asp:TextBox runat="server" ID="Member2" MaxLength="20" Width="200px" Text="Roll Number: Member 2"></asp:TextBox>
        <asp:TextBox runat="server" ID="Member3" MaxLength="20" Width="200px" Text="Roll Number: Member 3"></asp:TextBox>
        <br /><br />
        <asp:Label runat="server" ID="PTitle">Project Title</asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox runat="server" ID="protitle" MaxLength="20" Width="200px" Text="Project Title" TextMode="SingleLine"></asp:TextBox>
        <asp:TextBox runat="server" ID="prodes" MaxLength="20" Width="200px" Text="Breef Description about project." Height="50px"
            TextMode="MultiLine"
            ></asp:TextBox>
        <asp:FileUpload runat="server" ID="project_file" />
      
         <asp:Button runat="server" ID="submit_data" UseSubmitBehavior="true" OnClick="Submit_Click" Text="Submit" />
       
        <div>
            
    </div>
    </form>
    <hr />
   <div id="projectlist" runat="server" on>



    </div>
     <div  id="fl1" runat="server">



      
        </div>
       <style type="text/css">
             .flashcard {
        margin-right: 15px;
        padding: 10px;
        border: 1px solid #9b1010;
        height: 20%;
        width: 20%;
        float: left;
        font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
        color: whitesmoke;
    }
             .flashcard span{
                 float:right;
                 font-weight:bold;
                 font-size:larger;
                 color: white;
                 cursor: pointer;
             }
         </style>
    
</body>
</html>
