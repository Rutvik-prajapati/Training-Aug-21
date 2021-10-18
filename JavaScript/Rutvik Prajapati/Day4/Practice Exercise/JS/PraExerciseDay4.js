// What to Learn

// Callback
const students = [
    {name:"Rutvik", subject : "Javascript"},
    {name:"Rohan",subject:"Machine Learning"}
]

function enrollStudent(student, callback){
    setTimeout(function() {
        students.push(student);
        callback();
    }, 3000);
}

function getStudents(){
    setTimeout(function() {
        let str = "";
        students.forEach(function(student){
            str += `<li> ${student.name} </li>` 
        })
        document.getElementById('students').innerHTML = str;
    }, 1000);
}

let newStudent = {name:"ravi",subject:"Python"};
enrollStudent(newStudent,getStudents);

// Promises       
function fun1(){
    return new Promise(function(resolve,reject){
        var error = true;
        if(!error){
            console.log("fun : your promise has been resolved")
            resolve();
        }
        else{
            console.log("fun : your promise has not been resolved")
            reject("sorry requirment not fulfill");
        }
    })
}

fun1().then(function(){
    console.log("rutvik : thanks for resolved");
}).catch(function(error){
    console.log("rutvik : very bad." +error)
})

// Async and Await
    //async function same as promise ...
    //whenever any function before we use async keyword..it's become promise function. it 
    //return promise.

    //async
    async function test(){
        return "hello";
    }

    test().then(function(result){
        console.log(result);
    })

    //await
    async function test1(){
        console.log("2 : Message");
        await console.log("3 : Message");
        console.log("4 : Message");
    }
    console.log("1 : Message");
    test1();
    console.log("5 : Message");


    async function test2(){
        try{
            const response = await 3+3;
            return response;
        }
        catch(error){
            console.log(error);
        }
    }

    test2().then(function(res){
        console.log(res)
    })
