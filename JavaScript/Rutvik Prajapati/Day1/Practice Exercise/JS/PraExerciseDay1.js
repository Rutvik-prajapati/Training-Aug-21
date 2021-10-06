
// JavaScript Variables
    //var -- variable
    document.write("<h1>Variables</h1>");

    var x = "rutvik prajapati";
    document.write(x);

    document.write("<br>"); //for going on second line

    var y = 100;
    document.write(y);

    document.write("<br>"); //for going on second line

    var x = "new value";   // here you can declare second time variable ..
    document.write(x);

    document.write("<br>"); //for going on second line

    var stringValue = 'This is string Values';
    document.write(stringValue);

    document.write("<br>"); //for going on second line

    //let -- variable  
    // in let you cannot declare variable second time 
    let firstname = "Jaimin";
    //let firstname = "Raghav";//wrong
    firstname = "raghav"; //right
    document.write(firstname);

    document.write("<br>"); //for going on second line

    //const -- variable  constant.
    const second =  "Hello"
    document.write(second);

    document.write("<br>"); //for going on second line
    document.write("<br>"); //for going on second line

// Data types
    document.write("<h1>Data types</h1>");
    var a = "Hello world"               //string -data type
    var b = 25                          //Number -data type
    var c = true                        //Boolean -data type
    var d = ["HTML,CSS,JS"]             //Array -data type
    var e = {first:"Jane",last:"Doe"};  //Object -data type
    var f = null                        //Null -data type
    var g;                              //Undefined -data type

    document.write(a+" - ");
    document.write(typeof a);
    document.write("<br>"); //for going on second line

    document.write(b+" - ");
    document.write(typeof b);
    document.write("<br>"); //for going on second line

    document.write(c+" - ");
    document.write(typeof c);
    document.write("<br>"); //for going on second line
    
    document.write(d+" - ");
    document.write(typeof d);//in js array type is object
    document.write("<br>"); //for going on second line

    document.write(e+" - ");
    document.write(typeof e);
    document.write("<br>"); //for going on second line

    document.write(f+" - ");
    document.write(typeof f);//in js object type is object
    document.write("<br>"); //for going on second line

    document.write(g+" - ");
    document.write(typeof g);
    document.write("<br>"); //for going on second line

// Functions
    document.write("<h1>Functions</h1>");

    function fnABC()
    {
        document.write("Hello EveryOne");
        document.write("<br>");
    }

    fnABC();
    fnABC();

// Conditional construct
    document.write("<h1>Conditional construct</h1>");
    //if condition
    var d = 15;
    if(d>10){
        document.write(d+" is greater..");
        document.write("<br>");
    }

    //if else condition
    var g = 5;
    if(g>10){
        document.write(g+" is greater..");
        document.write("<br>");
    }
    else{
        document.write(g+" is not greater..");
        document.write("<br>");
    }

// For/While/foreach Loop
    document.write("<h1>For/While/foreach Loop</h1>");
    //For loop
    document.write("<h3>For loop</h3>");
    for(var q = 1;q<=10;q++)
    {
        document.write(q+" Hello EveryOne");
        document.write("<br>");
    }

    //While loop
    document.write("<h3>While loop</h3>")
    var q = 1;
    while(q<=10){
        document.write(q+" Rutvik Prajapati");
        document.write("<br>");
        q = q + 1;
    }
    document.write("<br>");

    //do while loop
    document.write("<h3>do while loop</h3>")
    var q = 1;
    do{
        document.write(q+" Rutvik Prajapati");
        document.write("<br>");
        q = q + 1;
    }
    while(q<=10)
    document.write("<br>");

    //forEach loop
    document.write("<h3>forEach loop</h3>");
    var j = ["Sanjay","Aman","Karan"];

    j.forEach(function(value,index){
        document.write(index + ":"+value+"<br>");
    });

// Array
    document.write("<h1>Array</h1>");
    //array
    var sum = 0;
    var v = [10,20,30,40,50];
    document.write(v);
    document.write("<br>");
    document.write(v[4]);
    document.write("<ul>");
    for(var t = 0;t<=4;t++)
    {
        document.write("<li>"+v[t]+"</li>");
        sum = sum+v[t];
    }
    document.write("</ul>");
    document.write("Total sum : "+sum);

// Methods
    document.write("<h1>Methods</h1>");

    //array 

    var l = new Array(); //undefine value we can store
    //var l = new Array(3); //3 value we can store
    l[0] = 25;
    l[1] = "Rutvik";
    l[2] = true;

    document.write("<ul>");
    for(var i = 0;i<=4;i++)
    {
        document.write("<li>"+l[i]+"</li>");
    }
    document.write("</ul>");

// Events
    document.write("<h1>Events</h1>");
    // click(onclick)
        function hello(){
            alert("hello everyone");
        }
    // double click(ondblclick)
    function hello1(){
        alert("hello1 everyone");
    }
    // right click(oncontextmenu)
    function rightclk(){
        alert("hello1 everyone");
    }

    // mouse hover(onmouseenter)
    function mousehover(){
        alert("hello1 everyone");
    }
    // mouse out(onmouseout)
    function mouseout(){
        alert("hello1 everyone");
    }
    // mouse down(onmousedown)
    function mousedown(){
        alert("hello1 everyone");
    }
    // mouse up(onmouseup)
    function mouseup(){
        alert("hello1 everyone");
    }

// Upting the content of elements
var update = document.getElementsById("update").value;
update = "Update Content";
document.getElementById("update").innerHTML = update;
