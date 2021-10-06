// Array Method
    document.write("<h1>Array Method</h1>")
    var a  = ["harry",15,true,"BCA"];
    //delete array value 
    delete a[2];

    //sort() and reverse()
    document.write("<h2>Sort and Reverse method</h2>")
    var b = ["sanjay","rahul","jay","krupal"];
    b.sort();
    document.write("sort array : "+b+"<br>");

    b.reverse();
    document.write("reverse array : "+b+"<br>");

    //pop() and push()  in last 
    document.write("<h2>pop and push method</h2>");
    b.pop();  //array last value delete
    document.write("after pop array : "+b+"<br>");

    b.push("parth");
    document.write("after push array : "+b+"<br>");

    //shift() and unshift() in first
    document.write("<h2>shift and unshift method</h2>");
    b.shift(); //array first value delete
    document.write("after shift array : "+b+"<br>");

    b.unshift("kuldip");
    document.write("after unshift array : "+b+"<br>");

    //concat() and join() 
    document.write("<h2>concat and join method</h2>");
    var c = ["sanjay","rahul","jay"];

    var d = c.concat("karan","swetang");
    document.write("after concat array : "+d+"<br>");

        //OR
    var c = ["sanjay","rahul","jay"];
    var d = ["karan","swetang"];
    var e = c.concat(d);
    document.write("after concat array : "+e+"<br>");

    var d = c.join(" - ")
    document.write("after join array : "+d+"<br>");

    //slice() and splice()
    document.write("<h2>slice and splice method</h2>");
    document.write("array : "+b+"<br>");
    var d = b.slice(1,3);
    document.write("slice(1,3) array : "+d+"<br>");

    var d = b.slice(1);
    document.write("slice(1) array : "+d+"<br>");

    var d = b.slice(-3); //whenever give minus value array index is minus like 
                         //["sanjay","rahul","jay","krupal"] this array index values 
                         //[   -4   ,   -3  ,  -2 ,  -1   ]
    document.write("slice(-3) array : "+d+"<br>");


    b.splice(2,0,"Mahesh","Karan");
    document.write("splice(2,0,Mahesh,Karan) array : "+b+"<br>");

    //delete any array value
    b.splice(2,1)
    document.write("splice(2,1) array : "+b+"<br>");

    //isArray()
    document.write("<h2>isArray</h2>");
    document.write("array : "+b+"<br>");
    var d = Array.isArray(b);
    document.write("Is array : "+d+"<br>");

    var w = 20;
    document.write("w variable value : "+w+"<br>");
    var d = Array.isArray(w);
    document.write("Is array : "+d+"<br>");

// String/String Method
    document.write("<h1>String Method</h1>");

    //length properties
    document.write("<h2>length</h2>");
    var str = "This is a great Language";
    document.write("string value : "+str+"<br>");
    var z = str.length;
    document.write("string length : "+z+"<br>");

    //toLowerCase and  toUpperCase methods
    document.write("<h2>toLowerCase and  toUpperCase </h2>");
    document.write("string value : "+str+"<br>");
    var z = str.toLowerCase();
    document.write("string toLowerCase : "+z+"<br>");
    var z = str.toUpperCase();
    document.write("string toUpperCase : "+z+"<br>");

    //includes -- search some word..return true flase
    document.write("<h2>includes </h2>");
    document.write("string value : "+str+"<br>");
    var z = str.includes("great");
    document.write("great word exist or not? : "+z+"<br>");
    var z = str.includes("language");
    document.write("language word exist or not? : "+z+"<br>");

    //startsWith and endsWith
    document.write("<h2>startsWith and endsWith </h2>");
    document.write("string value : "+str+"<br>");
      //startsWith -- first word in string find 
      var z = str.startsWith("This");
      document.write("This word exect match with first word? : "+z+"<br>");
      //endsWith -- end word in string find
      var z = str.startsWith("language");
      document.write("language word exect match with first word? : "+z+"<br>");

    //search -- same as includes but search return index position not ture/flase.
    document.write("<h2>search </h2>");
    document.write("string value : "+str+"<br>");
    var z = str.search("language");
    document.write("language word index value : "+z+"<br>");
    var z = str.search("Language");
    document.write("Language word index value : "+z+"<br>");

    //match -- exect match return array
    document.write("<h2>match </h2>");
    var str = "This is is great Language";
    document.write("string value : "+str+"<br>");
    var z = str.match(/is/g);
    document.write("match array value : "+z+"<br>");

    //indexof and lastindexof
    document.write("<h2>indexof and lastindexof </h2>");
    document.write("string value : "+str+"<br>");
    var z = str.indexOf("is");
    document.write("is indexOf value : "+z+"<br>");
    var z = str.lastIndexOf("is");
    document.write("is lastIndexOf value : "+z+"<br>");

    //replace
    document.write("<h2>replace</h2>");
    document.write("string value : "+str+"<br>");
    var z = str.replace("This","Js");
    document.write("after replace function string value : "+z+"<br>");

    //trim -- space remove
    document.write("<h2>trim</h2>");
    var str = "             Js         ";
    document.write("string value : "+str+"<br>");
    var z = str.trim();
    document.write("after trim function string value : "+z+"<br>");

// Number/Number Method
    document.write("<h1>Number/Number Method</h1>");

    //number
    document.write("<h2>number</h2>");
    var num = "99";
    document.write("num variable contain string value : "+num+"<br>");
    var n = Number(num);
    document.write("num value convert into number value : "+n+"<br>");

    //parseInt and parseFloat
    document.write("<h2>parseInt and parseFloat</h2>");
    var num = "99";
    document.write("num variable contain string value : "+num+"<br>");
    var n = parseInt(num);
    document.write("num value convert into number using parseInt value : "+n+"<br>");

    var num = "53.22";
    document.write("num variable contain string value : "+num+"<br>");
    var n = parseFloat(num);
    document.write("num value convert into number using parseFloat value : "+n+"<br>");

    //isfinite and isinteger
    document.write("<h2>isfinite and isinteger</h2>");
    var num = 100;
    document.write("number value : "+num+"<br>");
    var n = Number.isFinite(num);
    document.write("num isfinite or not? : "+n+"<br>");

    var num = "hello";
    document.write("number value : "+num+"<br>");
    var n = Number.isFinite(num);
    document.write("num isfinite or not? : "+n+"<br>");

    var num = 100;
    document.write("number value : "+num+"<br>");
    var n = Number.isInteger(num);
    document.write("num isinteger or not? : "+n+"<br>");

    var num = 100.152;
    document.write("number value : "+num+"<br>");
    var n = Number.isInteger(num);
    document.write("num isinteger or not? : "+n+"<br>");

    //toFixed and toPrecision
    document.write("<h2>toFixed and toPrecision</h2>");
    var num = 100.1524258;
    document.write("number value : "+num+"<br>");
    var n = num.toFixed(2);
    document.write("num toFixed(2) : "+n+"<br>");
    var n = num.toFixed(3);
    document.write("num toFixed(3) : "+n+"<br>");

    var n = num.toPrecision(2);
    document.write("num toPrecision(2) : "+n+"<br>");

// Date/Date Method
    document.write("<h1>Date/Date Method</h1>");

    var now = new Date();
    document.write("Date : "+now+"<br>");
    //toDateString
    document.write("<h2>toDateString</h2>");
    document.write("Date value : "+now.toDateString()+"<br>");

    //getDate,getFullYear,getMonth,getDay
    document.write("<h2>getDate,getFullYear,getMonth,getDay</h2>");
    document.write("getDate() value : "+now.getDate()+"<br>");
    document.write("getFullYear() value : "+now.getFullYear()+"<br>");
    document.write("getMonth() value : "+now.getMonth()+"<br>");

    var date = new Date('January 2 2010');
    document.write("getDate() value : "+date.getDate()+"<br>");
    document.write("getFullYear() value : "+date.getFullYear()+"<br>");
    document.write("getMonth() value : "+date.getMonth()+"<br>");

    //getHours,getMinutes,getSeconds,getMilliseconds
    document.write("<h2>getHours,getMinutes,getSeconds,getMilliseconds</h2>");
    document.write("getHours() value : "+now.getHours()+"<br>");
    document.write("getMinutes() value : "+now.getMinutes()+"<br>");
    document.write("getSeconds() value : "+now.getSeconds()+"<br>");
    document.write("getMilliseconds() value : "+now.getMilliseconds()+"<br>");

    //setDate,setFullYear,setMonth,setHours,setMinutes,setSeconds,setMilliseconds
    document.write("<h2>setDate,setFullYear,setMonth,setHours,setMinutes,setSeconds,setMilliseconds</h2>");
    now.setDate(20);
    document.write("setDate() value : "+now+"<br>");
    now.setFullYear(2024);
    document.write("setFullYear() value : "+now+"<br>");
    now.setMonth(4);
    document.write("setMonth() value : "+now+"<br>");
    now.setHours(14);
    document.write("setHours() value : "+now+"<br>");

// Regular Expression
    document.write("<h1>Regular Expression</h1>");
    document.write("Practice in Console<br>");
    var reg = /rutvik/;
    // reg = /rutvik/g; //global
    // reg = /rutvik/i;  //case insensitive

    console.log(reg);
    console.log(reg.source);

    //function to match expression

    let s = "This is great code with rutvik rutvik";

    //1.exec()
    let result = reg.exec(s);
    console.log(result);

    //2.test()  //returns true and false

    result = reg.test(s);
    console.log(result);

    //3.match() //return array of result or null

    result = s.match(reg)
    console.log(result);

    //4.search() return index of first match

    result = s.search(reg);
    console.log(result);

    //5.replace 
    result = s.replace(reg,"subham")
    console.log(result);
