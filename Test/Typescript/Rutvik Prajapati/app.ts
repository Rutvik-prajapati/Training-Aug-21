import {Restaurant } from './restaurants';
import {restaurantTable} from './restaurantTable';
import {Reservations} from './reservations';

var restaurantId:number;
var typeOfRoomName:string;
var numberOfGuest:number;

restaurantId = 2;
typeOfRoomName = "Ac Room";
numberOfGuest = 100;


var res = new Restaurant();
var resTable = new restaurantTable();
var reservations = new Reservations(restaurantId,typeOfRoomName,numberOfGuest);



res.GetRestaurantList();
console.log();
resTable.getResTableList();
console.log();
console.log("Restaurant Id : "+restaurantId);
console.log("Type Of Room Name : "+typeOfRoomName);
console.log("Number Of Guest : "+numberOfGuest);
console.log();
reservations.booking();
