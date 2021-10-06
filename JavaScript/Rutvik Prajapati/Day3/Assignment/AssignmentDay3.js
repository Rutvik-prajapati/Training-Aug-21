function formValidate(eId, eName, eAge, eGender, eDesignation, eSalary, eLocation, eEmailId,
  eDateJoin, eContactNumber) {
  var reg = /^[0-9]{5}$/g;

  // if(eId == "" || eName == "" || eAge == "" || eGender == "" || eDesignation == "" || 
  //   eSalary == "" || eLocation == "" || eEmailId == "" || eDateJoin == "" || 
  //   eContactNumber == "")
  //   {
  //     document.getElementById("empIdValidation").innerHTML = "Please Enter Number";
  //     document.getElementById("empNameValidation").innerHTML = "Please Enter Employee Name";
  //     document.getElementById("empAgeValidation").innerHTML = "Please Enter Age";
  //     document.getElementById("empGenderValidation").innerHTML = "Please Select Gender";
  //     document.getElementById("empDesignationValidation").innerHTML = "Please Enter Number";
  //     document.getElementById("empSalaryValidation").innerHTML = "Please Enter Number";
  //     document.getElementById("empLocationValidation").innerHTML = "Please Enter Number";
  //     document.getElementById("empEmailIdValidation").innerHTML = "Please Enter Number";
  //     document.getElementById("empDOJValidation").innerHTML = "Please Enter Number";
  //     document.getElementById("empContactNumValidation").innerHTML = "Please Enter Number";
  //   }
  // else if(){

  // }

  //employeeId
  if(eId == ""){
    document.getElementById("empIdValidation").innerHTML = "Please Enter Number";
    return false;
  }
  else{
    if(isNaN(eId)){
      document.getElementById("empIdValidation").innerHTML = "Enter Only Number";
      return false;
    }
    if(eId != null && !reg.test(eId))
    {
      document.getElementById("empIdValidation").innerHTML = "Enter 5 digit Number";
      return false;
    }
    document.getElementById("empIdValidation").innerHTML = "";
  }

  //employeeName
  if(eName == "")
  {
    document.getElementById("empNameValidation").innerHTML = "Please Enter Employee Name";
    return false;
  }
  else{
    document.getElementById("empNameValidation").innerHTML = "";
  }

  //employee Age
  if(eAge == "")
  {
    document.getElementById("empAgeValidation").innerHTML = "Please Enter Age";
    return false;
  }
  else{
    if(isNaN(eAge)){
      document.getElementById("empAgeValidation").innerHTML = "Enter Only Number";
      return false;
    }
    if(!(eAge.length >= 1 && eAge.length <= 2)){
      document.getElementById("empAgeValidation").innerHTML = "Enter 1 or 2 digit Number";
      return false;
    }
    document.getElementById("empAgeValidation").innerHTML = "";
  }

  //employee Gender
  if(eGender == "")
  {
    document.getElementById("empGenderValidation").innerHTML = "Please Select Gender";
    return false;
  }
  else{
    document.getElementById("empGenderValidation").innerHTML = "";
  }

  //employee designation
  if(eDesignation == "")
  {
    document.getElementById("empDesignationValidation").innerHTML = "Please enter designation";
    return false;
  }
  else{
    document.getElementById("empDesignationValidation").innerHTML = "";
  }

  //employee salary
  if(eSalary == "")
  {
    document.getElementById("empSalaryValidation").innerHTML = "Please enter salary";
    return false;
  }
  else{
    if(isNaN(eSalary)){
      document.getElementById("empSalaryValidation").innerHTML = "Enter Only Number";
      return false;
    }
    document.getElementById("empSalaryValidation").innerHTML = "";
  }

  //employee location
  if(eLocation == "")
  {
    document.getElementById("empLocationValidation").innerHTML = "Please select location";
    return false;
  }
  else{
    if(eLocation == 'Select Location'){
      document.getElementById("empLocationValidation").innerHTML = "Please select location";
      return false;
    }
    document.getElementById("empLocationValidation").innerHTML = "";
  }

  //employee email
  if(eEmailId == "")
  {
    document.getElementById("empEmailIdValidation").innerHTML = "Please enter emailId";
    return false;
  }
  else{
    if(eEmailId.indexOf('@')<=0){
      document.getElementById("empEmailIdValidation").innerHTML = "@ Invalid Position";
      return false;
    }
    if((eEmailId.charAt(eEmailId.length-4) != '.') && 
      (eEmailId.charAt(eEmailId.length-3) != '.')){ //rutvik@gmail.com
      document.getElementById("empEmailIdValidation").innerHTML = ". Invalid Position";
      return false;
    }
    document.getElementById("empEmailIdValidation").innerHTML = "";
  }

  //employee date of joining
  if(eDateJoin == "")
  {
    document.getElementById("empDOJValidation").innerHTML = "Please enter joining date";
    return false;
  }
  else{
    document.getElementById("empDOJValidation").innerHTML = "";
  }

  //employee contact number
  if(eContactNumber == "")
  {
    document.getElementById("empContactNumValidation").innerHTML = "Please enter contact number";
    return false;
  }
  else{
    if(isNaN(eContactNumber)){
      document.getElementById("empContactNumValidation").innerHTML = "Enter Only Number";
      return false;
    }
    if(eContactNumber.length != 10){
      document.getElementById("empContactNumValidation").innerHTML = "Enter 10 digit Number";
      return false;
    }
    document.getElementById("empContactNumValidation").innerHTML = "";
  }


  if (eId != "" && eId != null) {
    if (Number.isInteger(empId)) {  //&& reg.test(eId)
      document.getElementById("empIdValidation").innerHTML = "number must 5 digit";
      
      console.log("test");
    }

  }
  else {
    document.getElementById("empIdValidation").innerHTML = "please enter number";
    return false;
  }
}

