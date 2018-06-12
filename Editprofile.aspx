<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="Editprofile.aspx.cs" Inherits="Editprofile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<link href="editprofilesheet.css" rel="stylesheet" type="text/css" />
    
 <div class="slider">
    <input type="radio" name="image" id="i1" checked=checked/>
    <input type="radio" name="image" id="i2"/>
    <input type="radio" name="image" id="i3"/>
    <input type="radio" name="image" id="i4"/>
        
        <div class="slide" id="one">
           <img src="1.jpg" alt="" />
           <div></div>
           <label for="i4" class="pre"></label>
           <label for="i2" class="next"></label>
        </div>
        <div class="slide" id="two">
           <img src="2.jpg" alt="" />
           <label for="i1" class="pre"></label>
           <label for="i3" class="next"></label>
        </div>
        <div class="slide" id="three">
           <img src="3.jpg" alt="" />
           <label for="i2" class="pre"></label>
           <label for="i4" class="next"></label>
        </div>
        <div class="slide" id="four">
           <img src="4.jpg" alt="" />
           <label for="i3" class="pre"></label>
           <label for="i1" class="next"></label>
        </div>

        <div class="nav">
           <label class="dots" id="dot1" for="i1"></label>
           <label class="dots" id="dot2" for="i2"></label>
           <label class="dots" id="dot3" for="i3"></label>
           <label class="dots" id="dot4" for="i4"></label>
        </div>
    </div>


    <div class="head">
    </div>
    <div class="data">
                     <div class="profile">
                           
                           <div class="details">
                               
                                                              
                                 <table>

                                       <tr class="table">
                                          <td class="t1"><p class="p">First Name:</p></td>
                                          <td><asp:TextBox ID="fname" runat="server" CssClass="text"></asp:TextBox></td>
                                          
                                       </tr>

                                       <tr class="table">
                                          <td class="t1"><p class="p">Last Name:</p></td>
                                          <td><asp:TextBox ID="lname" runat="server" CssClass="text" AutoComplete="off"></asp:TextBox></td>
                                          
                                       </tr>

                                       <tr class="table">
                                          <td class="t1"><p class="p">Gender:</p></td>
                                          <td>
                                              <asp:RadioButtonList ID="gender" runat="server">
                                              <asp:ListItem>Male</asp:ListItem>
                                              <asp:ListItem>Female</asp:ListItem>
                                              </asp:RadioButtonList>
                                          </td>
                                          
                                       </tr>

                                       <tr class="table">
                                          <td class="t1"><p class="p">User Name:</p></td>
                                          <td><asp:TextBox ID="username" runat="server" CssClass="text" AutoComplete="off"></asp:TextBox></td>
                                          
                                       </tr>


                                       <tr class="table">
                                          <td class="t1"><p class="p">E-Mail:</p></td>
                                          <td><asp:TextBox ID="email" runat="server" CssClass="text" AutoComplete="off"></asp:TextBox></td>
                                          
                                       </tr>

                                       <tr class="table">
                                          <td class="t1"><p class="p">Mobile No:</p></td>
                                          <td><asp:TextBox ID="phone" runat="server" CssClass="text" AutoComplete="off"></asp:TextBox></td>
                                          
                                       </tr>

                                       <tr class="table">
                                          <td class="t1"><p class="p">Professionality:</p></td>
                                          <td><asp:TextBox ID="pro" runat="server" CssClass="text" AutoComplete="off"></asp:TextBox></td>
                                          
                                       </tr>

                                       <tr class="table">
                                          <td class="t1"></td>
                                          <td><asp:Button ID="Submit" runat="server" Text="Submit" CssClass="submit" 
                                                  onclick="Submit_Click" /></td>
                                          
                                       </tr>

                                 </table>
                         
                           </div>
                         <a href="profile.aspx" class="edit">Go Back</a>
                     </div>

                     <div class="dashboard">
                          
                     </div>        
    </div>
    

    <script src="Scripts/jquery.min.js" type="text/javascript"></script>
    <script type="text/javascript">

        onload = start;

        function start() {
            var i = 1;
            function Move() {
                i = (i % 4) + 1; // 4 is the Number of image in slider
                document.getElementById('i' + i).checked = true;
            }
            setInterval(Move, 3000); //change img in 3 sec
        }
    </script>




</asp:Content>

