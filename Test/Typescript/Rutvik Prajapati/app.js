"use strict";
exports.__esModule = true;
var restaurants_1 = require("./restaurants");
var restaurantTable_1 = require("./restaurantTable");
var reservations_1 = require("./reservations");
var restaurantId;
var typeOfRoomName;
var numberOfGuest;
restaurantId = 2;
typeOfRoomName = "Ac Room";
numberOfGuest = 100;
var res = new restaurants_1.Restaurant();
var resTable = new restaurantTable_1.restaurantTable();
var reservations = new reservations_1.Reservations(restaurantId, typeOfRoomName, numberOfGuest);
res.GetRestaurantList();
console.log();
resTable.getResTableList();
console.log();
console.log("Restaurant Id : " + restaurantId);
console.log("Type Of Room Name : " + typeOfRoomName);
console.log("Number Of Guest : " + numberOfGuest);
console.log();
reservations.booking();
