//This project is aimed at developing a web-based and central Recruitment Process 
//System for the HR Group for a company. Some features of this system will be creating 
//vacancies, storing Applicants data, Interview process initiation, Scheduling Interviews, 
//Storing Interview results for the applicant and finally Hiring of the applicant. 
//Reports may be required to be generated for the use of HR group.

import { Vac, Vacancy } from './Vacancy'
import { applicant, Applicant } from './Applicant'
import { scheduledInterviews, InterviewSchedule } from './InterView'
import { res, Result } from './InterviewResult'

let vac1 = new Vacancy(12, 'software developer', 'IT', 50000, 'active')
let vac2 = new Vacancy(6, 'frontend developer', 'IT', 88000, 'active')
let applicant1 = new Applicant(1, 'smit', 'CE', 30000, 'ahmedabad', 12)
let applicant2 = new Applicant(2, 'ajay', 'IT', 25000, 'gandhinagar', 6)
let interview1 = new InterviewSchedule(112, 6, 2, '01/01/2021', 'ahmedabad')
let res1 = new Result(1, 'pass', 12)
res1.insertData()
vac1.insertData();
vac2.insertData();
applicant1.insertData();
applicant2.insertData();
interview1.insertData()
let x = Vac.filter((a) => {
    console.log(a.id);

})
console.log(applicant);
console.log(res);

