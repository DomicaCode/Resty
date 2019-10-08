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

/***/ "./wwwroot/js/foodItem.js":
/*!********************************!*\
  !*** ./wwwroot/js/foodItem.js ***!
  \********************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, \"default\", function() { return FoodItem; });\n/* harmony import */ var _helpers__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./helpers */ \"./wwwroot/js/helpers.js\");\n﻿\r\n\r\nclass FoodItem {\r\n    constructor() {\r\n        this.helpers = new _helpers__WEBPACK_IMPORTED_MODULE_0__[\"default\"]();\r\n    }\r\n\r\n    showAddFoodItem() {\r\n        document.getElementById('addFoodItemForm').style.display = 'block';\r\n    }\r\n\r\n    hideAddFoodItem() {\r\n        document.getElementById('addFoodItemForm').style.display = 'none';\r\n    }\r\n\r\n    addFoodItem() {\r\n        if ($('#addFoodItemForm').valid()) {\r\n        let formValue = this.helpers.getModel('#addFoodItemForm');\r\n\r\n        $.ajax({\r\n            type: 'POST',\r\n            url: \"/Admin/AddFoodItem\",\r\n            data: formValue,\r\n            dataType: \"application/json\",\r\n            success: function (data) {\r\n                window.location.reload();\r\n                console.log('yes');\r\n            },\r\n            error: function (data) {\r\n                window.location.reload();\r\n                console.log('no');\r\n            }\r\n        });\r\n\r\n        }\r\n    }\r\n}\n\n//# sourceURL=webpack://app/./wwwroot/js/foodItem.js?");

/***/ }),

/***/ "./wwwroot/js/helpers.js":
/*!*******************************!*\
  !*** ./wwwroot/js/helpers.js ***!
  \*******************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, \"default\", function() { return Helpers; });\n﻿class Helpers {\r\n    constructor() {\r\n    }\r\n\r\n    getModel(formSelector) {\r\n        const formData = $(formSelector).serializeArray();\r\n\r\n        return formData.reduce(function (result, curr) {\r\n            if (curr.name.startsWith(\"__\")) {\r\n                return result;\r\n            }\r\n\r\n            result[curr.name] = curr.value;\r\n            return result;\r\n        }, {});\r\n    }\r\n}\n\n//# sourceURL=webpack://app/./wwwroot/js/helpers.js?");

/***/ }),

/***/ "./wwwroot/js/main.js":
/*!****************************!*\
  !*** ./wwwroot/js/main.js ***!
  \****************************/
/*! exports provided: main */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, \"main\", function() { return main; });\n/* harmony import */ var _foodItem__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./foodItem */ \"./wwwroot/js/foodItem.js\");\n﻿\r\n\r\nclass Main {\r\n    constructor() {\r\n        this.foodItem = new _foodItem__WEBPACK_IMPORTED_MODULE_0__[\"default\"]();\r\n    }\r\n}\r\n\r\n\r\nconst main = new Main();\r\n\r\n\n\n//# sourceURL=webpack://app/./wwwroot/js/main.js?");

/***/ })

/******/ });