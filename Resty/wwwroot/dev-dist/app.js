var app =
/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, { enumerable: true, get: getter });
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 			Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 		}
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// create a fake namespace object
/******/ 	// mode & 1: value is a module id, require it
/******/ 	// mode & 2: merge all properties of value into the ns
/******/ 	// mode & 4: return value when already ns object
/******/ 	// mode & 8|1: behave like require
/******/ 	__webpack_require__.t = function(value, mode) {
/******/ 		if(mode & 1) value = __webpack_require__(value);
/******/ 		if(mode & 8) return value;
/******/ 		if((mode & 4) && typeof value === 'object' && value && value.__esModule) return value;
/******/ 		var ns = Object.create(null);
/******/ 		__webpack_require__.r(ns);
/******/ 		Object.defineProperty(ns, 'default', { enumerable: true, value: value });
/******/ 		if(mode & 2 && typeof value != 'string') for(var key in value) __webpack_require__.d(ns, key, function(key) { return value[key]; }.bind(null, key));
/******/ 		return ns;
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = "./wwwroot/js/main.js");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./wwwroot/js/Common.js":
/*!******************************!*\
  !*** ./wwwroot/js/Common.js ***!
  \******************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, \"default\", function() { return Common; });\n﻿class Common {\r\n    constructor() {\r\n    }\r\n\r\n    toggleMenu(e) {\r\n        e.preventDefault();\r\n        $('#adminSideMenu').slideToggle();\r\n    }\r\n}\n\n//# sourceURL=webpack://app/./wwwroot/js/Common.js?");

/***/ }),

/***/ "./wwwroot/js/OrderHub.js":
/*!********************************!*\
  !*** ./wwwroot/js/OrderHub.js ***!
  \********************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, \"default\", function() { return OrderHub; });\n﻿class OrderHub {\r\n    constructor() {\r\n        this.initialize();\r\n    }\r\n\r\n    async initialize() {\r\n        this.connection = new signalR.HubConnectionBuilder()\r\n            .withUrl('/orderHub')\r\n            .build();\r\n\r\n        await this.connection.start();\r\n    }\r\n}\n\n//# sourceURL=webpack://app/./wwwroot/js/OrderHub.js?");

/***/ }),

/***/ "./wwwroot/js/foodItem.js":
/*!********************************!*\
  !*** ./wwwroot/js/foodItem.js ***!
  \********************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, \"default\", function() { return FoodItem; });\n/* harmony import */ var _helpers__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./helpers */ \"./wwwroot/js/helpers.js\");\n﻿\r\n\r\nclass FoodItem {\r\n    constructor() {\r\n        this.helpers = new _helpers__WEBPACK_IMPORTED_MODULE_0__[\"default\"]();\r\n        this.areInputsHidden = true;\r\n    }\r\n\r\n    showAddFoodItem() {\r\n        document.getElementById('addFoodItemForm').style.display = 'block';\r\n        app.main.orderHub.connection.invoke(\"send\");\r\n    }\r\n\r\n    hideAddFoodItem() {\r\n        document.getElementById('addFoodItemForm').style.display = 'none';\r\n    }\r\n\r\n    addFoodItem() {\r\n        const form = $('#addFoodItemForm');\r\n        form.data('validator').settings.ignore = '';\r\n\r\n        if ($('#addFoodItemForm').valid()) {\r\n            const formValue = this.helpers.getModel('#addFoodItemForm');\r\n\r\n            $.ajax({\r\n                type: 'POST',\r\n                url: '/Administration/FoodItem/AddFoodItem',\r\n                data: formValue,\r\n                dataType: 'application/json',\r\n                success: function () {\r\n                    console.log('yes');\r\n                    window.location.reload();\r\n                },\r\n                error: function () {\r\n                    console.log('no');\r\n                    window.location.reload();\r\n                }\r\n            });\r\n        }\r\n    }\r\n\r\n    deleteFoodItem(event) {\r\n        const foodId = event.target.id;\r\n\r\n        $.ajax({\r\n            type: 'DELETE',\r\n            url: `/Administration/FoodItem/DeleteFoodItem?foodId=${foodId}`,\r\n            dataType: 'application/json',\r\n            success: function () {\r\n                window.location.reload();\r\n                console.log('yes');\r\n            },\r\n            error: function () {\r\n                window.location.reload();\r\n                console.log('no');\r\n            }\r\n        });\r\n    }\r\n\r\n    editFoodItem(event) {\r\n\r\n        const formId = $(event.target).parent().parent().attr('id');\r\n        const formValue = this.helpers.getModelTable(`#${formId}`);\r\n\r\n        $.ajax({\r\n            type: 'POST',\r\n            url: '/Administration/FoodItem/EditFoodItem',\r\n            data: formValue,\r\n            dataType: 'application/json',\r\n            success: function () {\r\n                console.log('yes');\r\n                window.location.reload();\r\n            },\r\n            error: function () {\r\n                console.log('no');\r\n                window.location.reload();\r\n            }\r\n        });\r\n\r\n        console.log(event.target);\r\n    }\r\n}\n\n//# sourceURL=webpack://app/./wwwroot/js/foodItem.js?");

/***/ }),

/***/ "./wwwroot/js/foodItemCategory.js":
/*!****************************************!*\
  !*** ./wwwroot/js/foodItemCategory.js ***!
  \****************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, \"default\", function() { return FoodItemCategory; });\n/* harmony import */ var _helpers__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./helpers */ \"./wwwroot/js/helpers.js\");\n﻿\r\n\r\nclass FoodItemCategory {\r\n    constructor() {\r\n        this.helpers = new _helpers__WEBPACK_IMPORTED_MODULE_0__[\"default\"]();\r\n        this.areInputsHidden = true;\r\n    }\r\n\r\n    showAddFoodItemCategory() {\r\n        document.getElementById('addFoodItemCategoryForm').style.display = 'block';\r\n    }\r\n\r\n    hideAddFoodItemCategory() {\r\n        document.getElementById('addFoodItemCategoryForm').style.display = 'none';\r\n    }\r\n\r\n    addFoodItemCategory() {\r\n        if ($('#addFoodItemCategoryForm').valid()) {\r\n            const formValue = this.helpers.getModel('#addFoodItemCategoryForm');\r\n\r\n            $.ajax({\r\n                type: 'POST',\r\n                url: '/Administration/FoodItemCategory/AddFoodItemCategory',\r\n                data: formValue,\r\n                dataType: 'application/json',\r\n                success: function () {\r\n                    window.location.reload();\r\n                    console.log('yes');\r\n                },\r\n                error: function () {\r\n                    window.location.reload();\r\n                    console.log('no');\r\n                }\r\n            });\r\n        }\r\n    }\r\n\r\n    deleteFoodItemCategory(event) {\r\n        const foodCategoryId = event.target.id;\r\n\r\n        $.ajax({\r\n            type: 'DELETE',\r\n            url: `/Administration/FoodItemCategory/DeleteFoodItemCategory?foodId=${foodCategoryId}`,\r\n            dataType: 'application/json',\r\n            success: function () {\r\n                window.location.reload();\r\n                console.log('yes');\r\n            },\r\n            error: function () {\r\n                window.location.reload();\r\n                console.log('no');\r\n            }\r\n        });\r\n    }\r\n\r\n    editFoodItemCategory(event) {\r\n\r\n        const formId = $(event.target).parent().parent().attr('id');\r\n        const formValue = this.helpers.getModelTable(`#${formId}`);\r\n\r\n        $.ajax({\r\n            type: 'POST',\r\n            url: '/Administration/FoodItemCategory/EditFoodItemCategory',\r\n            data: formValue,\r\n            dataType: 'application/json',\r\n            success: function () {\r\n                console.log('yes');\r\n                window.location.reload();\r\n            },\r\n            error: function () {\r\n                console.log('no');\r\n                window.location.reload();\r\n            }\r\n        });\r\n\r\n        console.log(event.target);\r\n    }\r\n}\n\n//# sourceURL=webpack://app/./wwwroot/js/foodItemCategory.js?");

/***/ }),

/***/ "./wwwroot/js/helpers.js":
/*!*******************************!*\
  !*** ./wwwroot/js/helpers.js ***!
  \*******************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, \"default\", function() { return Helpers; });\n﻿class Helpers {\r\n    constructor() {\r\n    }\r\n\r\n    getModel(formSelector) {\r\n        const formData = $(formSelector).serializeArray();\r\n\r\n        return formData.reduce(function (result, curr) {\r\n            if (curr.name.startsWith('__')) {\r\n                return result;\r\n            }\r\n\r\n            result[curr.name] = curr.value;\r\n            return result;\r\n        }, {});\r\n    }\r\n\r\n    getModelTable(formSelector) {\r\n        const formData = $(formSelector + ' :input').serializeArray();\r\n\r\n        return formData.reduce(function (result, curr) {\r\n            if (curr.name.startsWith('__')) {\r\n                return result;\r\n            }\r\n\r\n            result[curr.name] = curr.value;\r\n            return result;\r\n        }, {});\r\n    }\r\n}\n\n//# sourceURL=webpack://app/./wwwroot/js/helpers.js?");

/***/ }),

/***/ "./wwwroot/js/main.js":
/*!****************************!*\
  !*** ./wwwroot/js/main.js ***!
  \****************************/
/*! exports provided: main */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, \"main\", function() { return main; });\n/* harmony import */ var _foodItem__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./foodItem */ \"./wwwroot/js/foodItem.js\");\n/* harmony import */ var _foodItemCategory__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./foodItemCategory */ \"./wwwroot/js/foodItemCategory.js\");\n/* harmony import */ var _OrderHub__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./OrderHub */ \"./wwwroot/js/OrderHub.js\");\n/* harmony import */ var _Common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./Common */ \"./wwwroot/js/Common.js\");\n﻿\r\n\r\n\r\n\r\n\r\nclass Main {\r\n    constructor() {\r\n        this.foodItem = new _foodItem__WEBPACK_IMPORTED_MODULE_0__[\"default\"]();\r\n        this.foodItemCategory = new _foodItemCategory__WEBPACK_IMPORTED_MODULE_1__[\"default\"]();\r\n        this.orderHub = new _OrderHub__WEBPACK_IMPORTED_MODULE_2__[\"default\"]();\r\n        this.common = new _Common__WEBPACK_IMPORTED_MODULE_3__[\"default\"]();\r\n    }\r\n}\r\n\r\nconst main = new Main();\r\n\r\n\n\n//# sourceURL=webpack://app/./wwwroot/js/main.js?");

/***/ })

/******/ });