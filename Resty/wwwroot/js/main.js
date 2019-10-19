import FoodItem from './foodItem';
import FoodItemCategory from './foodItemCategory';
import OrderHub from './OrderHub';
import Common from './Common';

class Main {
    constructor() {
        this.foodItem = new FoodItem();
        this.foodItemCategory = new FoodItemCategory();
        this.orderHub = new OrderHub();
        this.common = new Common();
    }
}

const main = new Main();

export {
    main,
};