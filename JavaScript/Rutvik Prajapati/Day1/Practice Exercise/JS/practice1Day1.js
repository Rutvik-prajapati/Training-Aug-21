// Accept three numbers from the user using prompt, find the greater of these the
// numbers and do the sum of that numbers which are greater than 40.

var num = 40;
var sum = 0;
var num1 = parseInt(prompt("Enter First Number:"));
var num2 = parseInt(prompt("Enter Second Number:"));
var num3 = parseInt(prompt("Enter Third Number:"));

if(num1>num)
{
    sum+=num1;
}
if(num2>num)
{
    sum+=num2;
}
if(num3>num)
{
    sum+=num3;
}

document.getElementById("total").innerHTML="Sum of number which greater than 40 : "+sum

console.log("Sum of number which greater than 40 : "+sum);
