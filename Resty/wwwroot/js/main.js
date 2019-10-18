import FoodItem from './foodItem';
import FoodItemCategory from './foodItemCategory';
import OrderHub from './OrderHub';

class Main {
    constructor() {
        this.foodItem = new FoodItem();
        this.foodItemCategory = new FoodItemCategory();
        this.orderHub = new OrderHub();
    }
}

const main = new Main();

export {
    main,
};