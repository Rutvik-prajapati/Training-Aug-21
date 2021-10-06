// What to Learn:


    // Windows
    document.write("<h1>Windows</h1>");
    document.write("<h2>Windows Methods</h2>");
    // alert("this is windows methods.");
    // var a = prompt("enter any value..");
    // var a = confirm("are you sure?");

    window.document.getElementById("header");
       //OR
    document.getElementById("header");
    function myFunction() {
        alert('Hello');
    }

        //innerHeight,innerWidth,outerHeight,outerWidth
        document.write("<h2>innerHeight,innerWidth,outerHeight,outerWidth</h2>");
        var iHeight = window.innerHeight;
        console.log("InnerHeight : "+iHeight);

        var oHeight = window.outerHeight;
        console.log("OuterHeight : "+oHeight);

        var iWidth = window.innerWidth;
        console.log("InnerWidth : "+iWidth);

        var oWidth = window.outerHeight;
        console.log("OuterWidth : "+oWidth);

        //open and close
        document.write("<h2>open and close</h2>");
        var myWindow;
        function openWindow(){
            myWindow = window.open("","","width=200px,height=200px");
            myWindow.document.write("<p>This is new window</p>")
        }
        function closeWindow(){
            myWindow.close();
        }

        //moveby and moveto  both are same
        function moveWindow(){
            myWindow.moveTo(100,100);
            window.focus();
        }

        //resizeBy and resizeTo
        function resizeWindow(){
            myWindow.resizeTo(400,400);
        }

        //scrollBy and scrollTo
        function scrollWindow(){
            window.scrollBy(0,20);
          //window.scrollBy(x,y);
        }

    // location
        console.log(location);
        console.log(location.hash);
        console.log(location.host);
        console.log(location.hostname);
        console.log(location.href);
        console.log(location.port);
        console.log(location.protocol);
        console.log(location.search);

    // Navigator
    document.write("<h1>Navigator</h1>");
    document.write("<h2>navigator.cookieEnabled</h2>");
    document.getElementById("demo").innerHTML =
    "navigator.cookieEnabled is " + navigator.cookieEnabled;

    // History
    console.log(history);
    console.log(history.length);

    function backFunction(){
        history.back();
    }

    function forwardFunction(){
        history.forward();
    }