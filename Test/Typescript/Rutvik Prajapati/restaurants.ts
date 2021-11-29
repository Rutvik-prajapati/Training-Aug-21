var RestaurantData:{ restaurantId: number, restaurantName: string }[] = [{restaurantId:1,restaurantName:"A One Restaurant"},
{restaurantId:2,restaurantName:"Palet Restaurant"}];

export class Restaurant{
        GetRestaurantList()
        {
            RestaurantData.forEach(element => {
                console.log("Restaurant Id : "+element.restaurantId+"   Restaurant Name : "+element.restaurantName);
            });
        }
}