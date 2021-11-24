export {}
//  Datatypes
    //boolean
    let isFinal:boolean = false;

    //Number
    let decimalNum:number = 123;

    //string
    let firstname:string = "Rutvik Prajapati";

    //array
    let list:number[] = [1,11,111];

    //tuple  --fixed size of array. types are know, but not need to same  
    let x:[number,string];
    x = [10,"rutvik"];


//  Type Annotation
    var lastname:string = "Thakkar";
    //lastname = 20 ; error gives 

    function addnum() : number
    {
        return 10+10;
    }
    //lastname = addnum();  error gives

//  Number
    let fixeddNum:number = 123.12;
    let first:number = 0b101011;

//  Number Methods
    //toExponetial()
    var exe = fixeddNum.toExponential();
    console.log(exe);

    //toFixed()
    var fix = fixeddNum.toFixed(3);
    console.log(fix);

    //toLocaleString()
    var localnum = fixeddNum.toLocaleString();
    console.log(localnum);

    //toPrecision()
    var precisionNum = fixeddNum.toPrecision(3);
    console.log(precisionNum)

//  String/Template String
    var firstName:string = "Rutvik";
    var LastName:string ="Prajapati";
    var fullname:string = firstName+ " " +LastName;   //or
    var FullName:string = `${firstName} ' ' ${LastName}`;

//  String Methods
    //concat()
    var concatString:string = firstName.concat(LastName);
    console.log(concatString);

    //toUpperCase()
    var upperCase = firstName.toUpperCase();
    console.log(upperCase);

    //toLowerCase()
    var lowerCase = firstName.toLowerCase();
    console.log(lowerCase);

    //split()
    var splitString = FullName.split(' ',2);
    console.log(splitString);

//  Any
    var anyValue:any = "Hi"
    anyValue = true;
    anyValue = 123;
    function processData(a:any,b:any)
    {
        return a+b;
    }
    console.log(processData(2,"Rutvik"));
    console.log(processData(2,10));

//  Array /Array Methods
    var arr:number[] = [1,10,20];

    //add new item
    arr.push(30);

    //remove item
    arr.pop();

    //sort()
    arr.sort();
    