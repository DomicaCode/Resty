import Helpers from "./helpers";

export default class FoodItem {
    constructor() {
        this.helpers = new Helpers();
    }

    showAddFoodItem() {
        document.getElementById('addFoodItemForm').style.display = 'block';
    }

    hideAddFoodItem() {
        document.getElementById('addFoodItemForm').style.display = 'none';
    }

    addFoodItem() {
        if ($('#addFoodItemForm').valid()) {
        let formValue = this.helpers.getModel('#addFoodItemForm');

        $.ajax({
            type: 'POST',
            url: "/Admin/AddFoodItem",
            data: formValue,
            dataType: "application/json",
            success: function (data) {
                window.location.reload();
                console.log('yes');
            },
            error: function (data) {
                window.location.reload();
                console.log('no');
            }
        });

        }
    }

    deleteFoodItem(event) {
        let foodId = event.target.value;

        $.ajax({
            type: 'DELETE',
            url: "/Admin/DeleteFoodItem?foodId=" + foodId,
            dataType: "application/json",
            success: function (data) {
                window.location.reload();
                console.log('yes');
            },
            error: function (data) {
                window.location.reload();
                console.log('no');
            }
        });
    }
}