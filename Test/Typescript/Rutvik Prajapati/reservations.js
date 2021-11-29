"use strict";
exports.__esModule = true;
exports.Reservations = void 0;
var generateRandomToken_1 = require("./generateRandomToken");
var restaurantTable_1 = require("./restaurantTable");
var Reservations = /** @class */ (function () {
    function Reservations(Id, typeOfRoom, guest) {
        this.sixHourAgodate = new Date();
        this.oneMonthAgodate = new Date();
        this.restaurantTables = new restaurantTable_1.restaurantTable();
        this.restaurantId = Id;
        this.typeOfRoom = typeOfRoom;
        this.numberOfGuest = guest;
    }
    Reservations.prototype.booking = function () {
        var isExist = this.restaurantTables.checkTableExist(this.restaurantId, this.typeOfRoom, this.numberOfGuest);
        if (isExist == true) {
            this.sixHourAgodate.setHours(this.sixHourAgodate.getHours() - 6);
            this.oneMonthAgodate.setMonth(this.oneMonthAgodate.getMonth() - 1);
            var currentDate = new Date();
            if (this.sixHourAgodate <= currentDate || this.oneMonthAgodate < currentDate) {
                console.log("Booking SuccessFully");
                console.log("Customer acknowledgement srting/token: " + (0, generateRandomToken_1.makeid)(40));
            }
        }
        else
            console.log("We do not have enough table.. ");
    };
    return Reservations;
}());
exports.Reservations = Reservations;
