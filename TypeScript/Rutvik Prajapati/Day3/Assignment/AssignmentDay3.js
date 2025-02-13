"use strict";
//This project is aimed at developing a web-based and central Recruitment Process 
//System for the HR Group for a company. Some features of this system will be creating 
//vacancies, storing Applicants data, Interview process initiation, Scheduling Interviews, 
//Storing Interview results for the applicant and finally Hiring of the applicant. 
//Reports may be required to be generated for the use of HR group.
exports.__esModule = true;
var Vacancy_1 = require("./Vacancy");
var Applicant_1 = require("./Applicant");
var InterView_1 = require("./InterView");
var InterviewResult_1 = require("./InterviewResult");
var vac1 = new Vacancy_1.Vacancy(12, 'software developer', 'IT', 50000, 'active');
var vac2 = new Vacancy_1.Vacancy(6, 'frontend developer', 'IT', 88000, 'active');
var applicant1 = new Applicant_1.Applicant(1, 'smit', 'CE', 30000, 'ahmedabad', 12);
var applicant2 = new Applicant_1.Applicant(2, 'ajay', 'IT', 25000, 'gandhinagar', 6);
var interview1 = new InterView_1.InterviewSchedule(112, 6, 2, '01/01/2021', 'ahmedabad');
var res1 = new InterviewResult_1.Result(1, 'pass', 12);
res1.insertData();
vac1.insertData();
vac2.insertData();
applicant1.insertData();
applicant2.insertData();
interview1.insertData();
var x = Vacancy_1.Vac.filter(function (a) {
    console.log(a.id);
});
console.log(Applicant_1.applicant);
console.log(InterviewResult_1.res);
