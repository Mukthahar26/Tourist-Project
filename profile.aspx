<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<link href="profilesheet.css" rel="stylesheet" type="text/css" />
    
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
                                          <td><p id="fname" runat="server" class="p1"></p></td>
                                          
                                       </tr>

                                       <tr class="table">
                                          <td class="t1"><p class="p">Last Name:</p></td>
                                          <td><p id="lname" runat="server" class="p1"></p></td>
                                          
                                       </tr>

                                       <tr class="table">
                                          <td class="t1"><p class="p">Gender:</p></td>
                                          <td><p class="p1" id="gender" runat="server"></p></td>
                                          
                                       </tr>

                                       <tr class="table">
                                          <td class="t1"><p class="p">User Name:</p></td>
                                          <td><p id="username" runat="server" class="p1"></p></td>
                                          
                                       </tr>

                                       <tr class="table">
                                          <td class="t1"><p class="p">E-Mail:</p></td>
                                          <td><p id="email" runat="server" class="p1"></p></td>
                                          
                                       </tr>

                                       <tr class="table">
                                          <td class="t1"><p class="p">Mobile No:</p></td>
                                          <td><p id="phone" runat="server" class="p1"></p></td>
                                          
                                       </tr>

                                       <tr class="table">
                                          <td class="t1"><p class="p">Professionality:</p></td>
                                          <td><p id="pro" runat="server" class="p1"></p></td>
                                          
                                       </tr>

                                 </table>
                         
                           </div>
                         <a href="Editprofile.aspx" class="edit">Edit Profile</a>
                     </div>

                     <div class="dashboard">
                          
                     </div>
        
    </div>
    <asp:Image ID="Image1" runat="server" />
    
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

