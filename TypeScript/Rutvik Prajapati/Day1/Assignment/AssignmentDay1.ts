// 1.  Store 5 employees’ data in one array (ID,FirstName,LastName,Address,Salary).
//  Do the operation searching by indexnumber, EmployeeID, Insert the employee, delete 
//  the employee from the Array. Create one more array emp and join the value with above 
//  array. When display list combine firstname and lastname as fullname, From the address 
//  field flatnumber,city,state and should be splited.PF should be computed and total 
//  salary should be display.
export{}
var employeeData = [{Id:1, FirstName:"Rutvik",LastName:"Prajapati",Address:"A-101 Modasa Gujarat",Salary:25000},
                    {Id:2, FirstName:"Parth",LastName:"Patel",Address:"B-200 Gandhinagar Gujarat",Salary:30000},
                    {Id:3, FirstName:"Kuldip",LastName:"Jambukiya",Address:"A-126 Delhi Delhi",Salary:50000},
                    {Id:4, FirstName:"Jay",LastName:"Thakkar",Address:"G-521 Mumbai Maharastra",Salary:35000},
                    {Id:5, FirstName:"Maulik",LastName:"Shah",Address:"T-122 Modasa Gujarat",Salary:18000}];

employeeData.forEach(element => {
    console.log(element.Id +' '+element.FirstName+" "+element.LastName+" "+element.Address+" "+element.Salary);
});

//search
console.log("Search by Index number");

function searchByIndexNum(index){
  return employeeData[index];
}

console.log(searchByIndexNum(2));

console.log("Search by Employee Id");
function searchByEmloyeeIdNum(employeeId){
    return employeeData.filter(e=>e.Id == employeeId);
}
console.log(searchByEmloyeeIdNum(2));


//add new employee
var newEmployee = {
    Id : 6,
    FirstName:"Mehul",
    LastName:"Patel",
    Address:"C-502 Gandhinagar Gujarat",
    Salary:80000
}
employeeData.push(newEmployee);

//delete employee
employeeData.pop();


//join two array 
var newEmployeeArray = [{Id:1, FirstName:"Raghav",LastName:"Prajapati",Address:"A-101 Modasa Gujarat",Salary:65000},
                        {Id:2, FirstName:"Krupal",LastName:"Shah",Address:"B-200 Gandhinagar Gujarat",Salary:10000}];

employeeData = employeeData.concat(newEmployeeArray);

console.log(employeeData);

employeeData.forEach(emp => {
    console.log("FullName : "+emp.FirstName+' '+emp.LastName);
    console.log("Address : "+emp.Address.split(' ',3));
    var PF = (0.9*emp.Salary)/100;
    console.log("PF : "+PF);
    console.log("Salary : "+(emp.Salary - PF));
    console.log("\n");
});