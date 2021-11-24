//What to Learn
//Class
var Employee = /** @class */ (function () {
    function Employee(Id, Name) {
        this.EmployeeID = Id;
        this.EmployeeName = Name;
    }
    Employee.prototype.getSalary = function () {
        return 25000;
    };
    return Employee;
}());
var empObj = new Employee(1, "Rutvik");
console.log(empObj.getSalary());
//Function
//Enum
var Status;
(function (Status) {
    Status[Status["success"] = 0] = "success";
    Status[Status["fail"] = 1] = "fail";
})(Status || (Status = {}));
var s;
var statusVal = Status.success;
console.log(statusVal);
//Interface
//Tuples
var a;
a = [1, "Rutvik"];
console.log(a);
var employee;
employee = [[1, "Kamal"], [2, "Chaya"], [3, "Raj"]];
console.log(employee[0]);
//Union
var unionVar;
unionVar = 12;
console.log(unionVar);
unionVar = "Rajesh";
console.log(unionVar);
unionVar = true;
console.log(unionVar);
