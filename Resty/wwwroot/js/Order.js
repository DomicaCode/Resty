import Helpers from './helpers';

export default class Order {
    constructor() {
        this.foodId = null;
        this.helpers = new Helpers();
    }

    showAddOrder(event) {
        this.foodId = event.target.id;
        $('#addOrderForm').show();
    }

    hideAddOrder() {
        $('#addOrderForm').hide();
    }

    addOrder() {
        const form = $('#addOrderForm');
        form.data('validator').settings.ignore = '';

        if ($('#addOrderForm').valid()) {
            const formValue = this.helpers.getModel('#addOrderForm');
            formValue.foodItemId = this.foodId;

            $.ajax({
                type: 'POST',
                url: '/Global/Menu/AddOrder',
                data: formValue,
                dataType: 'json',
                success: function() {
                    app.main.orderHub.connection.invoke('send');
                },
                error: function() {
                }
            });
        }
    }

    updateOrders() {
        $.ajax({
            type: 'GET',
            url: '/Administration/Admin/GetOrderPartial',
            contentType: 'json',
            success: function(data) {
                $('#orderList').html(data);
            },
            error: function() {
            }
        });
    }
}
