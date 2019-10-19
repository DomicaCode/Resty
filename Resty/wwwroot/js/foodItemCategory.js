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
        const foodCategoryId = event.target.id;

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

    editFoodItemCategory(event) {

        const formId = $(event.target).parent().parent().attr('id');
        const formValue = this.helpers.getModelTable(`#${formId}`);

        $.ajax({
            type: 'POST',
            url: '/Administration/FoodItemCategory/EditFoodItemCategory',
            data: formValue,
            dataType: 'application/json',
            success: function () {
                console.log('yes');
                window.location.reload();
            },
            error: function () {
                console.log('no');
                window.location.reload();
            }
        });

        console.log(event.target);
    }
}