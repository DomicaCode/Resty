export default class Helpers {
    constructor() {
    }

    getModel(formSelector) {
        const formData = $(formSelector).serializeArray();

        return formData.reduce(function (result, curr) {
            if (curr.name.startsWith('__')) {
                return result;
            }

            result[curr.name] = curr.value;
            return result;
        }, {});
    }

    getModelTable(formSelector) {
        const formData = $(formSelector + ' :input').serializeArray();

        return formData.reduce(function (result, curr) {
            if (curr.name.startsWith('__')) {
                return result;
            }

            result[curr.name] = curr.value;
            return result;
        }, {});
    }
}