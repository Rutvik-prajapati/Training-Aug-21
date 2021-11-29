

var resTable:{ restaurantId: number, typeOfRoomName: string , availableTable:number }[] = [{restaurantId:1,typeOfRoomName:"AC room",availableTable:3},
                                                                                            {restaurantId:1,typeOfRoomName:"Non AC",availableTable:5},
                                                                                            {restaurantId:2,typeOfRoomName:"AC room",availableTable:1},
                                                                                            {restaurantId:2,typeOfRoomName:"Non AC",availableTable:2}]
interface IrestaurantTable {
    checkTableExist(resId:number,typeOfRoom:string,numberOfGuest:number):boolean;
    getResTableList();
}    

export class restaurantTable implements IrestaurantTable{
    checkTableExist(resId,typeOfRoom,numberOfGuest):boolean
    {
        var sumOfTable:number;
        var resNumberOfTable = resTable.filter(x=>x.restaurantId == resId && x.typeOfRoomName == typeOfRoom);
        resNumberOfTable.forEach(element => {
            sumOfTable = sumOfTable + element.availableTable;
        });
        if(sumOfTable*6 <=  numberOfGuest)
        {
            return false;
        }
        return true;
    }
    getResTableList()
    {
        resTable.forEach(element => {
            console.log("Restaurant Id : "+element.restaurantId+"   Type of Room : "+element.typeOfRoomName+"   Available No Of Table : "+element.availableTable);
        });
    }
}