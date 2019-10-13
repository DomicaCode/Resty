import FoodItem from './foodItem';
import FoodItemCategory from './foodItemCategory';

class Main {
    constructor() {
        this.foodItem = new FoodItem();
        this.foodItemCategory = new FoodItemCategory();
    }
}

const main = new Main();

export {
    main,
};