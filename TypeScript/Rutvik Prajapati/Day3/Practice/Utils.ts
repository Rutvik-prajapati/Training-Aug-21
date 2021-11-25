// 3. namespace  practice
       
/// <reference path="./testUtils.ts" />
namespace UsersUtils
{
    export class Users extends Parent implements userType{
        getName()
        {
            return this.name;
        }
    }
}

let u1 = new UsersUtils.Users();
u1.setName("Rutvik");
console.log(u1.getName());

