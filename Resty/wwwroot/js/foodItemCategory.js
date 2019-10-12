import Helpers from './helpers';

export default class FoodItemCategory {
    constructor() {
        this.helpers = new Helpers();
        this.areInputsHidden = true;
    }

    showAddFoodItemCategory() {
        document.getElementById('addFoodItemCategoryForm').style.display = 'block';
    }

    hideAddFoodItemCategory() {
        document.getElementById('addFoodItemCategoryForm').style.display = 'none';
    }

    addFoodItemCategory() {
        if ($('#addFoodItemCategoryForm').valid()) {
            const formValue = this.helpers.getModel('#addFoodItemCategoryForm');

            $.ajax({
                type: 'POST',
                url: '/Administration/FoodItemCategory/AddFoodItemCategory',
                data: formValue,
                dataType: 'application/json',
                success: function () {
                    window.location.reload();
                    console.log('yes');
                },
                error: function () {
                    window.location.reload();
                    console.log('no');
                }
            });
        }
    }

    deleteFoodItemCategory(event) {
        const foodCategoryId = event.target.value;

        $.ajax({
            type: 'DELETE',
            url: `/Administration/FoodItemCategory/DeleteFoodItemCategory?foodId=${foodCategoryId}`,
            dataType: 'application/json',
            success: function () {
                window.location.reload();
                console.log('yes');
            },
            error: function () {
                window.location.reload();
                console.log('no');
            }
        });
    }

    toggleEditFoodItemCategory () {
        this.areInputsHidden = !this.areInputsHidden;

        const foodCategoryId = event.target.id;

        $(`#foodItemCategoryForm-${foodCategoryId} :input`).prop('hidden', this.areInputsHidden);
        $(`#foodItemCategoryForm-${foodCategoryId}`).find('label').toggle();

        $(`#firstButtonRow-${foodCategoryId}`).toggle();
        $(`#secondButtonRow-${foodCategoryId}`).toggle();
    }
}