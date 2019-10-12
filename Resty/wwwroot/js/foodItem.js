import Helpers from './helpers';

export default class FoodItem {
    constructor() {
        this.helpers = new Helpers();
        this.areInputsHidden = true;
    }

    showAddFoodItem() {
        document.getElementById('addFoodItemForm').style.display = 'block';
    }

    hideAddFoodItem() {
        document.getElementById('addFoodItemForm').style.display = 'none';
    }

    addFoodItem() {
        if ($('#addFoodItemForm').valid()) {
            const formValue = this.helpers.getModel('#addFoodItemForm');

            $.ajax({
                type: 'POST',
                url: '/Administration/FoodItem/AddFoodItem',
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

    deleteFoodItem(event) {
        const foodId = event.target.value;

        $.ajax({
            type: 'DELETE',
            url: `/Administration/FoodItem/DeleteFoodItem?foodId=${foodId}`,
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

    toggleEditFoodItem() {
        this.areInputsHidden = !this.areInputsHidden;

        const foodId = event.target.id;

        $(`#foodItemForm-${foodId} :input`).prop('hidden', this.areInputsHidden);
        $(`#foodItemForm-${foodId}`).find('label').toggle();

        $(`#firstButtonRow-${foodId}`).toggle();
        $(`#secondButtonRow-${foodId}`).toggle();
    }
}