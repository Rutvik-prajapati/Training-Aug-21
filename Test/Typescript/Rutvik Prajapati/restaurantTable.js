"use strict";
exports.__esModule = true;
exports.restaurantTable = void 0;
var resTable = [{ restaurantId: 1, typeOfRoomName: "AC room", availableTable: 3 },
    { restaurantId: 1, typeOfRoomName: "Non AC", availableTable: 5 },
    { restaurantId: 2, typeOfRoomName: "AC room", availableTable: 1 },
    { restaurantId: 2, typeOfRoomName: "Non AC", availableTable: 2 }];
var restaurantTable = /** @class */ (function () {
    function restaurantTable() {
    }
    restaurantTable.prototype.checkTableExist = function (resId, typeOfRoom, numberOfGuest) {
        var sumOfTable;
        var resNumberOfTable = resTable.filter(function (x) { return x.restaurantId == resId && x.typeOfRoomName == typeOfRoom; });
        resNumberOfTable.forEach(function (element) {
            sumOfTable = sumOfTable + element.availableTable;
        });
        if (sumOfTable * 6 <= numberOfGuest) {
            return false;
        }
        return true;
    };
    restaurantTable.prototype.getResTableList = function () {
        resTable.forEach(function (element) {
            console.log("Restaurant Id : " + element.restaurantId + "   Type of Room : " + element.typeOfRoomName + "   Available No Of Table : " + element.availableTable);
        });
    };
    return restaurantTable;
}());
exports.restaurantTable = restaurantTable;
