<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="start.aspx.cs" Inherits="start" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<link href="startsheet.css" rel="stylesheet" type="text/css" />
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
<p id="disable" runat="server" class="aa" style="display:none"></p>
<div>
<div id="photo"></div>
<img src="redmark.png" alt="" class="mapic" />
<a href="goolemap.aspx" class="map" >Hyderabad Map</a>
     <h1 class="h1">We are here to give unforgotable tourism moments to our customers</h1>
     <p class="p">Our aim is to give excellent and wonderful moments to our tourist customers. Let us give a chance to serve you better. Providing best Hotels to
     stay, Providing Buses and providing best guide to you is our goal.</p>
</div>

<img class="img" src="city night.jpg" alt="" />
<h1 class="h1">"Quotes"</h1>
<h2 class="h2">"See the world. It's more fantastic than any dream made or paid for in factories. Ask for no guarantees, ask for no security."</h2>
<h2 class="h2">"We travel , not to escape life. But for life not to escape us."</h2>


<script src="Scripts/jquery.min.js" type="text/javascript"></script>
<script type = "text/javascript" >

    $(document).ready(function () {
        var r = $(".aa").text();
        (function (global) {
            if (r != "") {
                if (typeof (global) === "undefined") {
                    throw new Error("window is undefined");
                }

                var hash = "!";
                var noBackPlease = function () {
                    global.location.href += "#";

                    // making sure we have the fruit available for juice (^__^)
                    global.setTimeout(function () {
                        global.location.href += "!";
                    }, 50);
                };

                global.onhashchange = function () {
                    if (global.location.hash !== hash) {
                        global.location.hash = hash;
                    }
                };

                global.onload = function () {
                    noBackPlease();

                    // disables backspace on page except on input fields and textarea..
                    document.body.onkeydown = function (e) {
                        var elm = e.target.nodeName.toLowerCase();
                        if (e.which === 8 && (elm !== 'input' && elm !== 'textarea')) {
                            e.preventDefault();
                        }
                        // stopping event bubbling up the DOM tree..
                        e.stopPropagation();
                    };
                    PageMethods.f2();
                }
            }
        })(window);
    });



    
</script>

</asp:Content>

