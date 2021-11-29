import {makeid} from './generateRandomToken';
import {restaurantTable} from './restaurantTable';

interface IReservations{
    booking();
}

export class Reservations implements IReservations{
    restaurantId:number;
    typeOfRoom:string;
    numberOfGuest:number;
    sixHourAgodate = new Date();
    oneMonthAgodate= new Date();
    restaurantTables = new restaurantTable();

    constructor(Id:number,typeOfRoom:string,guest:number){
        this.restaurantId=Id;
        this.typeOfRoom=typeOfRoom;
        this.numberOfGuest=guest;
        
    }

    booking()
    {
        var isExist = this.restaurantTables.checkTableExist(this.restaurantId,this.typeOfRoom,this.numberOfGuest);
        if(isExist == true)
        {
            this.sixHourAgodate.setHours(this.sixHourAgodate.getHours() - 6);
            this.oneMonthAgodate.setMonth(this.oneMonthAgodate.getMonth() - 1);
            var currentDate =  new Date();

            if(this.sixHourAgodate <= currentDate  || this.oneMonthAgodate < currentDate)
            {
                console.log("Booking SuccessFully");
                console.log("Customer acknowledgement srting/token: "+makeid(40));
            }
        }
        else
            console.log("We do not have enough table.. ");  
    }

}

