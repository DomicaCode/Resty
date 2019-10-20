import FoodItem from './foodItem';
import FoodItemCategory from './foodItemCategory';
import OrderHub from './OrderHub';
import Common from './Common';
import Order from './Order';

class Main {
    constructor() {
        this.foodItem = new FoodItem();
        this.foodItemCategory = new FoodItemCategory();
        this.orderHub = new OrderHub();
        this.common = new Common();
        this.order = new Order();
    }
}

const main = new Main();

export {
    main,
};