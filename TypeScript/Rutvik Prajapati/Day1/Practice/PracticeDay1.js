"use strict";
exports.__esModule = true;
//  Datatypes
//boolean
var isFinal = false;
//Number
var decimalNum = 123;
//string
var firstname = "Rutvik Prajapati";
//array
var list = [1, 11, 111];
//tuple  --fixed size of array. types are know, but not need to same  
var x;
x = [10, "rutvik"];
//  Type Annotation
var lastname = "Thakkar";
//lastname = 20 ; error gives 
function addnum() {
    return 10 + 10;
}
//lastname = addnum();  error gives
//  Number
var fixeddNum = 123.12;
var first = 43;
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
console.log(precisionNum);
//  String/Template String
var firstName = "Rutvik";
var LastName = "Prajapati";
var fullname = firstName + " " + LastName; //or
var FullName = "".concat(firstName, " ' ' ").concat(LastName);
//  String Methods
//concat()
var concatString = firstName.concat(LastName);
console.log(concatString);
//toUpperCase()
var upperCase = firstName.toUpperCase();
console.log(upperCase);
//toLowerCase()
var lowerCase = firstName.toLowerCase();
console.log(lowerCase);
//split()
var splitString = FullName.split(' ', 2);
console.log(splitString);
//  Any
var anyValue = "Hi";
anyValue = true;
anyValue = 123;
function processData(a, b) {
    return a + b;
}
console.log(processData(2, "Rutvik"));
console.log(processData(2, 10));
//  Array /Array Methods
var arr = [1, 10, 20];
//add new item
arr.push(30);
//remove item
arr.pop();
//sort()
arr.sort();
