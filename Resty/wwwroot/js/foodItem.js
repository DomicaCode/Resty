import Helpers from './helpers';

export default class FoodItem {
    constructor() {
        this.helpers = new Helpers();
        this.areInputsHidden = true;
    }

    showAddFoodItem() {
        document.getElementById('addFoodItemForm').style.display = 'block';
        app.main.orderHub.connection.invoke("send");
    }

    hideAddFoodItem() {
        document.getElementById('addFoodItemForm').style.display = 'none';
    }

    addFoodItem() {
        const form = $('#addFoodItemForm');
        form.data('validator').settings.ignore = '';

        if ($('#addFoodItemForm').valid()) {
            const formValue = this.helpers.getModel('#addFoodItemForm');

            $.ajax({
                type: 'POST',
                url: '/Administration/FoodItem/AddFoodItem',
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
        }
    }

    deleteFoodItem(event) {
        const foodId = event.target.id;

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

    editFoodItem(event) {

        const formId = $(event.target).parent().parent().attr('id');
        const formValue = this.helpers.getModelTable(`#${formId}`);

        $.ajax({
            type: 'POST',
            url: '/Administration/FoodItem/EditFoodItem',
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