"use strict";
exports.__esModule = true;
var RetailShop = /** @class */ (function () {
    function RetailShop() {
        this.InventoryList = [{ Id: 1, Name: "Item1", Price: 100 }, { Id: 2, Name: "Iteml2", Price: 50 },
            { Id: 3, Name: "Item2", Price: 20 }, { Id: 4, Name: "", Price: 80 },
            { Id: 5, Name: "Item3", Price: 120 }, { Id: 5, Name: "Item3", Price: 120 }];
    }
    RetailShop.prototype.purchaseProduct = function () {
        if (this.InventoryList.length > 5) {
            this.InventoryList.pop();
            return "One Item Purchased.";
        }
        return "There are less than 5 item..please insert recond";
    };
    RetailShop.prototype.insertNewRecord = function (inventoryItem) {
        this.InventoryList.push(inventoryItem);
        return "One Inventory Item Inserted";
    };
    return RetailShop;
}());
var retailShopObj = new RetailShop();
var numVal = 1;
switch (numVal) {
    case 1:
        var result = retailShopObj.purchaseProduct();
        console.log(result);
        break;
    case 2:
        var inventoryItem = {
            Id: 7,
            Name: "NewItem",
            Price: 200
        };
        var result = retailShopObj.insertNewRecord(inventoryItem);
        console.log(result);
        break;
}
