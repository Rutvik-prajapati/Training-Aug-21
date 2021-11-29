"use strict";
exports.__esModule = true;
exports.Restaurant = void 0;
var RestaurantData = [{ restaurantId: 1, restaurantName: "A One Restaurant" },
    { restaurantId: 2, restaurantName: "Palet Restaurant" }];
var Restaurant = /** @class */ (function () {
    function Restaurant() {
    }
    Restaurant.prototype.GetRestaurantList = function () {
        RestaurantData.forEach(function (element) {
            console.log("Restaurant Id : " + element.restaurantId + "   Restaurant Name : " + element.restaurantName);
        });
    };
    return Restaurant;
}());
exports.Restaurant = Restaurant;
