(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./src/$$_lazy_route_resource lazy recursive":
/*!**********************************************************!*\
  !*** ./src/$$_lazy_route_resource lazy namespace object ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./src/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _model_model_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./model/model.module */ "./src/app/model/model.module.ts");
/* harmony import */ var _core_core_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./core/core.module */ "./src/app/core/core.module.ts");
/* harmony import */ var _core_table_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./core/table.component */ "./src/app/core/table.component.ts");
/* harmony import */ var _core_form_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./core/form.component */ "./src/app/core/form.component.ts");
/* harmony import */ var _messages_message_module__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./messages/message.module */ "./src/app/messages/message.module.ts");
/* harmony import */ var _messages_message_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./messages/message.component */ "./src/app/messages/message.component.ts");









var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [_angular_platform_browser__WEBPACK_IMPORTED_MODULE_2__["BrowserModule"], _model_model_module__WEBPACK_IMPORTED_MODULE_3__["ModelModule"], _core_core_module__WEBPACK_IMPORTED_MODULE_4__["CoreModule"], _messages_message_module__WEBPACK_IMPORTED_MODULE_7__["MessageModule"]],
            bootstrap: [_core_table_component__WEBPACK_IMPORTED_MODULE_5__["TableComponent"], _core_form_component__WEBPACK_IMPORTED_MODULE_6__["FormComponent"], _messages_message_component__WEBPACK_IMPORTED_MODULE_8__["MessageComponent"]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./src/app/core/core.module.ts":
/*!*************************************!*\
  !*** ./src/app/core/core.module.ts ***!
  \*************************************/
/*! exports provided: CoreModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CoreModule", function() { return CoreModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _model_model_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../model/model.module */ "./src/app/model/model.module.ts");
/* harmony import */ var _table_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./table.component */ "./src/app/core/table.component.ts");
/* harmony import */ var _form_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./form.component */ "./src/app/core/form.component.ts");
/* harmony import */ var _sharedState_model__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./sharedState.model */ "./src/app/core/sharedState.model.ts");
/* harmony import */ var rxjs_Subject__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! rxjs/Subject */ "./node_modules/rxjs-compat/_esm5/Subject.js");









var CoreModule = /** @class */ (function () {
    function CoreModule() {
    }
    CoreModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [_angular_platform_browser__WEBPACK_IMPORTED_MODULE_2__["BrowserModule"], _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"], _model_model_module__WEBPACK_IMPORTED_MODULE_4__["ModelModule"]],
            declarations: [_table_component__WEBPACK_IMPORTED_MODULE_5__["TableComponent"], _form_component__WEBPACK_IMPORTED_MODULE_6__["FormComponent"]],
            exports: [_model_model_module__WEBPACK_IMPORTED_MODULE_4__["ModelModule"], _table_component__WEBPACK_IMPORTED_MODULE_5__["TableComponent"], _form_component__WEBPACK_IMPORTED_MODULE_6__["FormComponent"]],
            providers: [{ provide: _sharedState_model__WEBPACK_IMPORTED_MODULE_7__["SHARED_STATE"], useValue: new rxjs_Subject__WEBPACK_IMPORTED_MODULE_8__["Subject"]() }]
        })
    ], CoreModule);
    return CoreModule;
}());



/***/ }),

/***/ "./src/app/core/form.component.css":
/*!*****************************************!*\
  !*** ./src/app/core/form.component.css ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "input.ng-dirty.ng-invalid { border: 2px solid #ff0000 }\r\ninput.ng-dirty.ng-valid { border: 2px solid #6bc502 }\r\n\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvY29yZS9mb3JtLmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUEsNEJBQTRCLDBCQUEwQjtBQUN0RCwwQkFBMEIsMEJBQTBCIiwiZmlsZSI6InNyYy9hcHAvY29yZS9mb3JtLmNvbXBvbmVudC5jc3MiLCJzb3VyY2VzQ29udGVudCI6WyJpbnB1dC5uZy1kaXJ0eS5uZy1pbnZhbGlkIHsgYm9yZGVyOiAycHggc29saWQgI2ZmMDAwMCB9XHJcbmlucHV0Lm5nLWRpcnR5Lm5nLXZhbGlkIHsgYm9yZGVyOiAycHggc29saWQgIzZiYzUwMiB9XHJcbiJdfQ== */"

/***/ }),

/***/ "./src/app/core/form.component.html":
/*!******************************************!*\
  !*** ./src/app/core/form.component.html ***!
  \******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"bg-primary p-a-1\" [class.bg-warning]=\"editing\">\r\n    <h5>{{editing ? \"Edit\" : \"Create\"}} Product</h5>\r\n</div>\r\n\r\n<form novalidate #form=\"ngForm\" (ngSubmit)=\"submitForm(form)\"\r\n                                (reset)=\"resetForm()\" >\r\n    <div class=\"form-group\">\r\n        <label>Name</label>\r\n        <input class=\"form-control\" name=\"name\"\r\n            [(ngModel)]=\"product.name\" required />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Category</label>\r\n        <input class=\"form-control\" name=\"category\"\r\n            [(ngModel)]=\"product.category\" required />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Price</label>\r\n        <input class=\"form-control\" name=\"price\"\r\n            [(ngModel)]=\"product.price\"\r\n            required pattern=\"^[0-9\\.]+$\" />\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\"\r\n        [class.btn-warning]=\"editing\" [disabled]=\"form.invalid\">\r\n        {{editing ? \"Save\" : \"Create\"}}\r\n    </button>\r\n    <button type=\"reset\" class=\"btn btn-secondary\">Cancel</button>\r\n</form>\r\n"

/***/ }),

/***/ "./src/app/core/form.component.ts":
/*!****************************************!*\
  !*** ./src/app/core/form.component.ts ***!
  \****************************************/
/*! exports provided: FormComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "FormComponent", function() { return FormComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _model_product_model__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../model/product.model */ "./src/app/model/product.model.ts");
/* harmony import */ var _model_repository_model__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../model/repository.model */ "./src/app/model/repository.model.ts");
/* harmony import */ var _sharedState_model__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./sharedState.model */ "./src/app/core/sharedState.model.ts");
/* harmony import */ var rxjs_Observable__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! rxjs/Observable */ "./node_modules/rxjs-compat/_esm5/Observable.js");






var FormComponent = /** @class */ (function () {
    function FormComponent(model, stateEvents) {
        var _this = this;
        this.model = model;
        this.stateEvents = stateEvents;
        this.product = new _model_product_model__WEBPACK_IMPORTED_MODULE_2__["Product"]();
        this.editing = false;
        stateEvents.subscribe(function (update) {
            _this.product = new _model_product_model__WEBPACK_IMPORTED_MODULE_2__["Product"]();
            if (update.id != undefined) {
                Object.assign(_this.product, _this.model.getProduct(update.id));
            }
            _this.editing = update.mode == _sharedState_model__WEBPACK_IMPORTED_MODULE_4__["MODES"].EDIT;
        });
    }
    FormComponent.prototype.submitForm = function (form) {
        if (form.valid) {
            this.model.saveProduct(this.product);
            this.product = new _model_product_model__WEBPACK_IMPORTED_MODULE_2__["Product"]();
            form.reset();
        }
    };
    FormComponent.prototype.resetForm = function () {
        this.product = new _model_product_model__WEBPACK_IMPORTED_MODULE_2__["Product"]();
    };
    FormComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: "paForm",
            template: __webpack_require__(/*! ./form.component.html */ "./src/app/core/form.component.html"),
            styles: [__webpack_require__(/*! ./form.component.css */ "./src/app/core/form.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__param"](1, Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"])(_sharedState_model__WEBPACK_IMPORTED_MODULE_4__["SHARED_STATE"])),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_model_repository_model__WEBPACK_IMPORTED_MODULE_3__["Model"],
            rxjs_Observable__WEBPACK_IMPORTED_MODULE_5__["Observable"]])
    ], FormComponent);
    return FormComponent;
}());



/***/ }),

/***/ "./src/app/core/sharedState.model.ts":
/*!*******************************************!*\
  !*** ./src/app/core/sharedState.model.ts ***!
  \*******************************************/
/*! exports provided: MODES, SharedState, SHARED_STATE */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MODES", function() { return MODES; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SharedState", function() { return SharedState; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SHARED_STATE", function() { return SHARED_STATE; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");

var MODES;
(function (MODES) {
    MODES[MODES["CREATE"] = 0] = "CREATE";
    MODES[MODES["EDIT"] = 1] = "EDIT";
})(MODES || (MODES = {}));
var SharedState = /** @class */ (function () {
    function SharedState(mode, id) {
        this.mode = mode;
        this.id = id;
    }
    return SharedState;
}());

var SHARED_STATE = new _angular_core__WEBPACK_IMPORTED_MODULE_0__["InjectionToken"]("shared_state");


/***/ }),

/***/ "./src/app/core/table.component.html":
/*!*******************************************!*\
  !*** ./src/app/core/table.component.html ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<table class=\"table table-sm table-bordered table-striped\">\r\n    <tr>\r\n        <th>ID</th><th>Name</th><th>Category</th><th>Price</th><th></th>\r\n    </tr>\r\n    <tr *ngFor=\"let item of getProducts()\">\r\n        <td style=\"vertical-align:middle\">{{item.id}}</td>\r\n        <td style=\"vertical-align:middle\">{{item.name}}</td>\r\n        <td style=\"vertical-align:middle\">{{item.category}}</td>\r\n        <td style=\"vertical-align:middle\">\r\n              {{item.price | currency:\"USD\":true }}\r\n        </td>\r\n        <td class=\"text-xs-center\">\r\n            <button class=\"btn btn-danger btn-sm\" (click)=\"deleteProduct(item.id)\">Delete</button>\r\n            <button class=\"btn btn-warning btn-sm\" (click)=\"editProduct(item.id)\">Edit</button>\r\n        </td>\r\n    </tr>\r\n</table>\r\n<button class=\"btn btn-primary\" (click)=\"createProduct()\">\r\n    Create New Product\r\n</button>\r\n"

/***/ }),

/***/ "./src/app/core/table.component.ts":
/*!*****************************************!*\
  !*** ./src/app/core/table.component.ts ***!
  \*****************************************/
/*! exports provided: TableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TableComponent", function() { return TableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _model_repository_model__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../model/repository.model */ "./src/app/model/repository.model.ts");
/* harmony import */ var _sharedState_model__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./sharedState.model */ "./src/app/core/sharedState.model.ts");




var TableComponent = /** @class */ (function () {
    function TableComponent(model, observer) {
        this.model = model;
        this.observer = observer;
    }
    TableComponent.prototype.getProduct = function (key) {
        return this.model.getProduct(key);
    };
    TableComponent.prototype.getProducts = function () {
        return this.model.getProducts();
    };
    TableComponent.prototype.deleteProduct = function (key) {
        this.model.deleteProduct(key);
    };
    TableComponent.prototype.editProduct = function (key) {
        this.observer.next(new _sharedState_model__WEBPACK_IMPORTED_MODULE_3__["SharedState"](_sharedState_model__WEBPACK_IMPORTED_MODULE_3__["MODES"].EDIT, key));
    };
    TableComponent.prototype.createProduct = function () {
        this.observer.next(new _sharedState_model__WEBPACK_IMPORTED_MODULE_3__["SharedState"](_sharedState_model__WEBPACK_IMPORTED_MODULE_3__["MODES"].CREATE));
    };
    TableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: "paTable",
            template: __webpack_require__(/*! ./table.component.html */ "./src/app/core/table.component.html")
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__param"](1, Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"])(_sharedState_model__WEBPACK_IMPORTED_MODULE_3__["SHARED_STATE"])),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_model_repository_model__WEBPACK_IMPORTED_MODULE_2__["Model"], Object])
    ], TableComponent);
    return TableComponent;
}());



/***/ }),

/***/ "./src/app/messages/message.component.html":
/*!*************************************************!*\
  !*** ./src/app/messages/message.component.html ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div *ngIf=\"lastMessage\"\r\n    class=\"bg-info p-a-1 text-xs-center\"\r\n    [class.bg-danger]=\"lastMessage.error\">\r\n    <h4>{{lastMessage.text}}</h4>\r\n</div>\r\n"

/***/ }),

/***/ "./src/app/messages/message.component.ts":
/*!***********************************************!*\
  !*** ./src/app/messages/message.component.ts ***!
  \***********************************************/
/*! exports provided: MessageComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MessageComponent", function() { return MessageComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _message_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./message.service */ "./src/app/messages/message.service.ts");



var MessageComponent = /** @class */ (function () {
    function MessageComponent(messageService) {
        var _this = this;
        messageService.registerMessageHandler(function (m) { return _this.lastMessage = m; });
    }
    MessageComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: "paMessages",
            template: __webpack_require__(/*! ./message.component.html */ "./src/app/messages/message.component.html"),
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_message_service__WEBPACK_IMPORTED_MODULE_2__["MessageService"]])
    ], MessageComponent);
    return MessageComponent;
}());



/***/ }),

/***/ "./src/app/messages/message.module.ts":
/*!********************************************!*\
  !*** ./src/app/messages/message.module.ts ***!
  \********************************************/
/*! exports provided: MessageModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MessageModule", function() { return MessageModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _message_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./message.component */ "./src/app/messages/message.component.ts");
/* harmony import */ var _message_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./message.service */ "./src/app/messages/message.service.ts");





var MessageModule = /** @class */ (function () {
    function MessageModule() {
    }
    MessageModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [_angular_platform_browser__WEBPACK_IMPORTED_MODULE_2__["BrowserModule"]],
            declarations: [_message_component__WEBPACK_IMPORTED_MODULE_3__["MessageComponent"]],
            exports: [_message_component__WEBPACK_IMPORTED_MODULE_3__["MessageComponent"]],
            providers: [_message_service__WEBPACK_IMPORTED_MODULE_4__["MessageService"]]
        })
    ], MessageModule);
    return MessageModule;
}());



/***/ }),

/***/ "./src/app/messages/message.service.ts":
/*!*********************************************!*\
  !*** ./src/app/messages/message.service.ts ***!
  \*********************************************/
/*! exports provided: MessageService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MessageService", function() { return MessageService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var MessageService = /** @class */ (function () {
    function MessageService() {
    }
    MessageService.prototype.reportMessage = function (msg) {
        if (this.handler != null) {
            this.handler(msg);
        }
    };
    MessageService.prototype.registerMessageHandler = function (handler) {
        this.handler = handler;
    };
    MessageService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
    ], MessageService);
    return MessageService;
}());



/***/ }),

/***/ "./src/app/model/model.module.ts":
/*!***************************************!*\
  !*** ./src/app/model/model.module.ts ***!
  \***************************************/
/*! exports provided: ModelModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ModelModule", function() { return ModelModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _repository_model__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./repository.model */ "./src/app/model/repository.model.ts");
/* harmony import */ var _angular_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/http */ "./node_modules/@angular/http/fesm5/http.js");
/* harmony import */ var _rest_datasource__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./rest.datasource */ "./src/app/model/rest.datasource.ts");





var ModelModule = /** @class */ (function () {
    function ModelModule() {
    }
    ModelModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [_angular_http__WEBPACK_IMPORTED_MODULE_3__["HttpModule"]],
            providers: [_repository_model__WEBPACK_IMPORTED_MODULE_2__["Model"], _rest_datasource__WEBPACK_IMPORTED_MODULE_4__["RestDataSource"],
                { provide: _rest_datasource__WEBPACK_IMPORTED_MODULE_4__["REST_URL"], useValue: "http://" + location.hostname + ":3500/products" }
            ]
        })
    ], ModelModule);
    return ModelModule;
}());



/***/ }),

/***/ "./src/app/model/product.model.ts":
/*!****************************************!*\
  !*** ./src/app/model/product.model.ts ***!
  \****************************************/
/*! exports provided: Product */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Product", function() { return Product; });
var Product = /** @class */ (function () {
    function Product(id, name, category, price) {
        this.id = id;
        this.name = name;
        this.category = category;
        this.price = price;
    }
    return Product;
}());



/***/ }),

/***/ "./src/app/model/repository.model.ts":
/*!*******************************************!*\
  !*** ./src/app/model/repository.model.ts ***!
  \*******************************************/
/*! exports provided: Model */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Model", function() { return Model; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _rest_datasource__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./rest.datasource */ "./src/app/model/rest.datasource.ts");



var Model = /** @class */ (function () {
    function Model(dataSource) {
        var _this = this;
        this.dataSource = dataSource;
        //private dataSource: SimpleDataSource;
        this.products = new Array();
        this.locator = function (p, id) { return p.id == id; };
        //this.dataSource = new SimpleDataSource();
        //this.products = new Array<Product>();
        //this.dataSource.getData().forEach(p => this.products.push(p));
        this.dataSource.getData().subscribe(function (data) { return _this.products = data; });
    }
    Model.prototype.getProducts = function () {
        return this.products;
    };
    Model.prototype.getProduct = function (id) {
        var _this = this;
        return this.products.find(function (p) { return _this.locator(p, id); });
    };
    Model.prototype.saveProduct = function (product) {
        var _this = this;
        if (product.id == 0 || product.id == null) {
            product.id = this.generateID();
            this.products.push(product);
        }
        else {
            var index = this.products
                .findIndex(function (p) { return _this.locator(p, product.id); });
            this.products.splice(index, 1, product);
        }
    };
    Model.prototype.deleteProduct = function (id) {
        var _this = this;
        var index = this.products.findIndex(function (p) { return _this.locator(p, id); });
        if (index > -1) {
            this.products.splice(index, 1);
        }
    };
    Model.prototype.generateID = function () {
        var candidate = 100;
        while (this.getProduct(candidate) != null) {
            candidate++;
        }
        return candidate;
    };
    Model = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_rest_datasource__WEBPACK_IMPORTED_MODULE_2__["RestDataSource"]])
    ], Model);
    return Model;
}());



/***/ }),

/***/ "./src/app/model/rest.datasource.ts":
/*!******************************************!*\
  !*** ./src/app/model/rest.datasource.ts ***!
  \******************************************/
/*! exports provided: REST_URL, RestDataSource */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "REST_URL", function() { return REST_URL; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RestDataSource", function() { return RestDataSource; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm5/operators/index.js");





var REST_URL = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["InjectionToken"]("rest_url");
var RestDataSource = /** @class */ (function () {
    function RestDataSource(http, url) {
        this.http = http;
        this.url = url;
    }
    RestDataSource.prototype.getData = function () {
        return this.sendRequest("GET", this.url);
    };
    RestDataSource.prototype.saveProduct = function (product) {
        return this.sendRequest("POST", this.url, product);
    };
    RestDataSource.prototype.updateProduct = function (product) {
        return this.sendRequest("PUT", this.url + "/" + product.id, product);
    };
    RestDataSource.prototype.deleteProduct = function (id) {
        return this.sendRequest("DELETE", this.url + "/" + id);
    };
    RestDataSource.prototype.sendRequest = function (verb, url, body) {
        var myHeaders = new _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpHeaders"]();
        myHeaders = myHeaders.set("Access-Key", "<secret>");
        myHeaders = myHeaders.set("Application-Names", ["exampleApp", "proAngular"]);
        return this.http.request(verb, url, {
            body: body,
            headers: myHeaders
        }).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["catchError"])(function (error) {
            return Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["throwError"])("Network Error: " + error.statusText + " (" + error.status + ")");
        }));
    };
    RestDataSource = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__param"](1, Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"])(REST_URL)),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"], String])
    ], RestDataSource);
    return RestDataSource;
}());



/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
var environment = {
    production: false
};
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(function (err) { return console.error(err); });


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Users\foxland\Dev\Lessons\Lessons3_Angular\exampleApp\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map