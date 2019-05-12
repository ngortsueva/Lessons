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
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _model_model_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./model/model.module */ "./src/app/model/model.module.ts");
/* harmony import */ var _common_common_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./common/common.module */ "./src/app/common/common.module.ts");
/* harmony import */ var _components_components_module__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./components/components.module */ "./src/app/components/components.module.ts");
/* harmony import */ var _components_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./components/component */ "./src/app/components/component.ts");








var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [_angular_platform_browser__WEBPACK_IMPORTED_MODULE_2__["BrowserModule"], _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"], _angular_forms__WEBPACK_IMPORTED_MODULE_3__["ReactiveFormsModule"],
                _model_model_module__WEBPACK_IMPORTED_MODULE_4__["ModelModule"], _common_common_module__WEBPACK_IMPORTED_MODULE_5__["CommonModule"], _components_components_module__WEBPACK_IMPORTED_MODULE_6__["ComponentsModule"]],
            bootstrap: [_components_component__WEBPACK_IMPORTED_MODULE_7__["ProductComponent"]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./src/app/common/addTax.pipe.ts":
/*!***************************************!*\
  !*** ./src/app/common/addTax.pipe.ts ***!
  \***************************************/
/*! exports provided: PaAddTaxPipe */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PaAddTaxPipe", function() { return PaAddTaxPipe; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var PaAddTaxPipe = /** @class */ (function () {
    function PaAddTaxPipe() {
        this.defaultRate = 10;
    }
    PaAddTaxPipe.prototype.transform = function (value, rate) {
        var valueNumber = Number.parseFloat(value);
        var rateNumber = rate == undefined ? this.defaultRate : Number.parseInt(rate);
        return valueNumber + (valueNumber * (rateNumber / 100));
    };
    PaAddTaxPipe = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Pipe"])({
            name: "addTax"
        })
    ], PaAddTaxPipe);
    return PaAddTaxPipe;
}());



/***/ }),

/***/ "./src/app/common/attr.directive.ts":
/*!******************************************!*\
  !*** ./src/app/common/attr.directive.ts ***!
  \******************************************/
/*! exports provided: PaAttrDirective */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PaAttrDirective", function() { return PaAttrDirective; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _model_product_model__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../model/product.model */ "./src/app/model/product.model.ts");





var PaAttrDirective = /** @class */ (function () {
    function PaAttrDirective(element) {
        this.element = element;
        this.click = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
    }
    PaAttrDirective.prototype.triggerCustomEvent = function () {
        if (this.product != null) {
            this.click.emit(this.product.category);
        }
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])("pa-attr"),
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostBinding"])("class"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
    ], PaAttrDirective.prototype, "bgClass", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])("pa-product"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _model_product_model__WEBPACK_IMPORTED_MODULE_2__["Product"])
    ], PaAttrDirective.prototype, "product", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])("pa-category"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PaAttrDirective.prototype, "click", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostListener"])("click"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Function),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", []),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:returntype", void 0)
    ], PaAttrDirective.prototype, "triggerCustomEvent", null);
    PaAttrDirective = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({
            selector: "[pa-attr]",
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"]])
    ], PaAttrDirective);
    return PaAttrDirective;
}());



/***/ }),

/***/ "./src/app/common/categoryFilter.pipe.ts":
/*!***********************************************!*\
  !*** ./src/app/common/categoryFilter.pipe.ts ***!
  \***********************************************/
/*! exports provided: PaCategoryFilterPipe */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PaCategoryFilterPipe", function() { return PaCategoryFilterPipe; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var PaCategoryFilterPipe = /** @class */ (function () {
    function PaCategoryFilterPipe() {
    }
    PaCategoryFilterPipe.prototype.transform = function (products, category) {
        return category == undefined ?
            products : products.filter(function (p) { return p.category == category; });
    };
    PaCategoryFilterPipe = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Pipe"])({
            name: "filter",
            pure: false
        })
    ], PaCategoryFilterPipe);
    return PaCategoryFilterPipe;
}());



/***/ }),

/***/ "./src/app/common/cellColor.directive.ts":
/*!***********************************************!*\
  !*** ./src/app/common/cellColor.directive.ts ***!
  \***********************************************/
/*! exports provided: PaCellColor */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PaCellColor", function() { return PaCellColor; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var PaCellColor = /** @class */ (function () {
    function PaCellColor() {
        this.bgClass = "";
    }
    PaCellColor.prototype.setColor = function (dark) {
        this.bgClass = dark ? "bg-dark" : "";
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostBinding"])("class"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
    ], PaCellColor.prototype, "bgClass", void 0);
    PaCellColor = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({
            selector: "td[paApplyColor]"
        })
    ], PaCellColor);
    return PaCellColor;
}());



/***/ }),

/***/ "./src/app/common/cellColorSwitcher.directive.ts":
/*!*******************************************************!*\
  !*** ./src/app/common/cellColorSwitcher.directive.ts ***!
  \*******************************************************/
/*! exports provided: PaCellColorSwitcher */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PaCellColorSwitcher", function() { return PaCellColorSwitcher; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _cellColor_directive__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./cellColor.directive */ "./src/app/common/cellColor.directive.ts");



var PaCellColorSwitcher = /** @class */ (function () {
    function PaCellColorSwitcher() {
    }
    PaCellColorSwitcher.prototype.ngOnChanges = function (changes) {
        this.updateContentChildren(changes["modelProperty"].currentValue);
    };
    PaCellColorSwitcher.prototype.ngAfterContentInit = function () {
        var _this = this;
        this.contentChildren.changes.subscribe(function () {
            setTimeout(function () { return _this.updateContentChildren(_this.modelProperty); }, 0);
        });
    };
    PaCellColorSwitcher.prototype.updateContentChildren = function (dark) {
        if (this.contentChildren != null && dark != undefined) {
            this.contentChildren.forEach(function (child, index) {
                child.setColor(index % 2 ? dark : !dark);
            });
        }
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])("paCellDarkColor"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Boolean)
    ], PaCellColorSwitcher.prototype, "modelProperty", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ContentChildren"])(_cellColor_directive__WEBPACK_IMPORTED_MODULE_2__["PaCellColor"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["QueryList"])
    ], PaCellColorSwitcher.prototype, "contentChildren", void 0);
    PaCellColorSwitcher = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({
            selector: "table"
        })
    ], PaCellColorSwitcher);
    return PaCellColorSwitcher;
}());



/***/ }),

/***/ "./src/app/common/common.module.ts":
/*!*****************************************!*\
  !*** ./src/app/common/common.module.ts ***!
  \*****************************************/
/*! exports provided: CommonModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CommonModule", function() { return CommonModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _addTax_pipe__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./addTax.pipe */ "./src/app/common/addTax.pipe.ts");
/* harmony import */ var _attr_directive__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./attr.directive */ "./src/app/common/attr.directive.ts");
/* harmony import */ var _categoryFilter_pipe__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./categoryFilter.pipe */ "./src/app/common/categoryFilter.pipe.ts");
/* harmony import */ var _cellColor_directive__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./cellColor.directive */ "./src/app/common/cellColor.directive.ts");
/* harmony import */ var _cellColorSwitcher_directive__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./cellColorSwitcher.directive */ "./src/app/common/cellColorSwitcher.directive.ts");
/* harmony import */ var _discount_pipe__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./discount.pipe */ "./src/app/common/discount.pipe.ts");
/* harmony import */ var _discountAmount_directive__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./discountAmount.directive */ "./src/app/common/discountAmount.directive.ts");
/* harmony import */ var _structure_directive__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./structure.directive */ "./src/app/common/structure.directive.ts");
/* harmony import */ var _iterator_directive__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./iterator.directive */ "./src/app/common/iterator.directive.ts");
/* harmony import */ var _twoway_directive__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./twoway.directive */ "./src/app/common/twoway.directive.ts");
/* harmony import */ var _discount_service__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./discount.service */ "./src/app/common/discount.service.ts");
/* harmony import */ var _log_service__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./log.service */ "./src/app/common/log.service.ts");
/* harmony import */ var _model_model_module__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ../model/model.module */ "./src/app/model/model.module.ts");


;













var CommonModule = /** @class */ (function () {
    function CommonModule() {
    }
    CommonModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [_model_model_module__WEBPACK_IMPORTED_MODULE_14__["ModelModule"]],
            declarations: [_addTax_pipe__WEBPACK_IMPORTED_MODULE_2__["PaAddTaxPipe"], _attr_directive__WEBPACK_IMPORTED_MODULE_3__["PaAttrDirective"], _categoryFilter_pipe__WEBPACK_IMPORTED_MODULE_4__["PaCategoryFilterPipe"],
                _twoway_directive__WEBPACK_IMPORTED_MODULE_11__["PaModel"], _cellColor_directive__WEBPACK_IMPORTED_MODULE_5__["PaCellColor"], _cellColorSwitcher_directive__WEBPACK_IMPORTED_MODULE_6__["PaCellColorSwitcher"], _discount_pipe__WEBPACK_IMPORTED_MODULE_7__["PaDiscountPipe"],
                _discountAmount_directive__WEBPACK_IMPORTED_MODULE_8__["PaDiscountAmountDirective"], _structure_directive__WEBPACK_IMPORTED_MODULE_9__["PaStructureDirective"], _iterator_directive__WEBPACK_IMPORTED_MODULE_10__["PaIteratorDirective"],
                _twoway_directive__WEBPACK_IMPORTED_MODULE_11__["PaModel"]],
            providers: [_discount_service__WEBPACK_IMPORTED_MODULE_12__["DiscountService"], _log_service__WEBPACK_IMPORTED_MODULE_13__["LogService"]],
            exports: [_addTax_pipe__WEBPACK_IMPORTED_MODULE_2__["PaAddTaxPipe"], _attr_directive__WEBPACK_IMPORTED_MODULE_3__["PaAttrDirective"], _categoryFilter_pipe__WEBPACK_IMPORTED_MODULE_4__["PaCategoryFilterPipe"],
                _cellColor_directive__WEBPACK_IMPORTED_MODULE_5__["PaCellColor"], _cellColorSwitcher_directive__WEBPACK_IMPORTED_MODULE_6__["PaCellColorSwitcher"], _discount_pipe__WEBPACK_IMPORTED_MODULE_7__["PaDiscountPipe"],
                _discountAmount_directive__WEBPACK_IMPORTED_MODULE_8__["PaDiscountAmountDirective"], _iterator_directive__WEBPACK_IMPORTED_MODULE_10__["PaIteratorDirective"], _structure_directive__WEBPACK_IMPORTED_MODULE_9__["PaStructureDirective"],
                _twoway_directive__WEBPACK_IMPORTED_MODULE_11__["PaModel"]]
        })
    ], CommonModule);
    return CommonModule;
}());



/***/ }),

/***/ "./src/app/common/discount.pipe.ts":
/*!*****************************************!*\
  !*** ./src/app/common/discount.pipe.ts ***!
  \*****************************************/
/*! exports provided: PaDiscountPipe */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PaDiscountPipe", function() { return PaDiscountPipe; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _discount_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./discount.service */ "./src/app/common/discount.service.ts");



var PaDiscountPipe = /** @class */ (function () {
    function PaDiscountPipe(discount) {
        this.discount = discount;
    }
    PaDiscountPipe.prototype.transform = function (price) {
        return this.discount.applyDiscount(price);
    };
    PaDiscountPipe = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Pipe"])({
            name: "discount",
            pure: false
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_discount_service__WEBPACK_IMPORTED_MODULE_2__["DiscountService"]])
    ], PaDiscountPipe);
    return PaDiscountPipe;
}());



/***/ }),

/***/ "./src/app/common/discount.service.ts":
/*!********************************************!*\
  !*** ./src/app/common/discount.service.ts ***!
  \********************************************/
/*! exports provided: DiscountService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DiscountService", function() { return DiscountService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _log_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./log.service */ "./src/app/common/log.service.ts");



var DiscountService = /** @class */ (function () {
    function DiscountService(logger) {
        this.logger = logger;
        this.discountValue = 10;
    }
    Object.defineProperty(DiscountService.prototype, "discount", {
        get: function () {
            return this.discountValue;
        },
        set: function (newValue) {
            this.discountValue = newValue || 0;
        },
        enumerable: true,
        configurable: true
    });
    DiscountService.prototype.applyDiscount = function (price) {
        this.logger.logInfoMessage("Discount " + this.discount
            + (" applied to price: " + price));
        return Math.max(price - this.discountValue, 5);
    };
    DiscountService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_log_service__WEBPACK_IMPORTED_MODULE_2__["LogService"]])
    ], DiscountService);
    return DiscountService;
}());



/***/ }),

/***/ "./src/app/common/discountAmount.directive.ts":
/*!****************************************************!*\
  !*** ./src/app/common/discountAmount.directive.ts ***!
  \****************************************************/
/*! exports provided: PaDiscountAmountDirective */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PaDiscountAmountDirective", function() { return PaDiscountAmountDirective; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _discount_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./discount.service */ "./src/app/common/discount.service.ts");



var PaDiscountAmountDirective = /** @class */ (function () {
    function PaDiscountAmountDirective(keyValueDiffers, changeDetector, discount) {
        this.keyValueDiffers = keyValueDiffers;
        this.changeDetector = changeDetector;
        this.discount = discount;
    }
    PaDiscountAmountDirective.prototype.ngOnInit = function () {
        this.differ =
            this.keyValueDiffers.find(this.discount).create();
    };
    PaDiscountAmountDirective.prototype.ngOnChanges = function (changes) {
        if (changes["originalPrice"] != null) {
            this.updateValue();
        }
    };
    PaDiscountAmountDirective.prototype.ngDoCheck = function () {
        if (this.differ.diff(this.discount) != null) {
            this.updateValue();
        }
    };
    PaDiscountAmountDirective.prototype.updateValue = function () {
        this.discountAmount = this.originalPrice
            - this.discount.applyDiscount(this.originalPrice);
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])("pa-price"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Number)
    ], PaDiscountAmountDirective.prototype, "originalPrice", void 0);
    PaDiscountAmountDirective = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({
            selector: "td[pa-price]",
            exportAs: "discount"
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["KeyValueDiffers"],
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["ChangeDetectorRef"],
            _discount_service__WEBPACK_IMPORTED_MODULE_2__["DiscountService"]])
    ], PaDiscountAmountDirective);
    return PaDiscountAmountDirective;
}());



/***/ }),

/***/ "./src/app/common/iterator.directive.ts":
/*!**********************************************!*\
  !*** ./src/app/common/iterator.directive.ts ***!
  \**********************************************/
/*! exports provided: PaIteratorDirective */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PaIteratorDirective", function() { return PaIteratorDirective; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var PaIteratorDirective = /** @class */ (function () {
    function PaIteratorDirective(container, template, differs, changeDetector) {
        this.container = container;
        this.template = template;
        this.differs = differs;
        this.changeDetector = changeDetector;
        this.views = new Map();
    }
    PaIteratorDirective.prototype.ngOnInit = function () {
        this.differ = this.differs.find(this.dataSource).create();
    };
    PaIteratorDirective.prototype.ngDoCheck = function () {
        var _this = this;
        var changes = this.differ.diff(this.dataSource);
        if (changes != null) {
            changes.forEachAddedItem(function (addition) {
                var context = new PaIteratorContext(addition.item, addition.currentIndex, changes.length);
                context.view = _this.container.createEmbeddedView(_this.template, context);
                _this.views.set(addition.trackById, context);
            });
            var removals_1 = false;
            changes.forEachRemovedItem(function (removal) {
                removals_1 = true;
                var context = _this.views.get(removal.trackById);
                if (context != null) {
                    _this.container.remove(_this.container.indexOf(context.view));
                    _this.views.delete(removal.trackById);
                }
            });
            if (removals_1) {
                var index_1 = 0;
                this.views.forEach(function (context) {
                    return context.setData(index_1++, _this.views.size);
                });
            }
        }
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])("paForOf"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PaIteratorDirective.prototype, "dataSource", void 0);
    PaIteratorDirective = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({
            selector: "[paForOf]"
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewContainerRef"],
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["TemplateRef"],
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["IterableDiffers"],
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["ChangeDetectorRef"]])
    ], PaIteratorDirective);
    return PaIteratorDirective;
}());

var PaIteratorContext = /** @class */ (function () {
    function PaIteratorContext($implicit, position, total) {
        this.$implicit = $implicit;
        this.position = position;
        this.setData(position, total);
    }
    PaIteratorContext.prototype.setData = function (index, total) {
        this.index = index;
        this.odd = index % 2 == 1;
        this.even = !this.odd;
        this.first = index == 0;
        this.last = index == total - 1;
    };
    return PaIteratorContext;
}());


/***/ }),

/***/ "./src/app/common/log.service.ts":
/*!***************************************!*\
  !*** ./src/app/common/log.service.ts ***!
  \***************************************/
/*! exports provided: LogLevel, LogService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LogLevel", function() { return LogLevel; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LogService", function() { return LogService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var LogLevel;
(function (LogLevel) {
    LogLevel[LogLevel["DEBUG"] = 0] = "DEBUG";
    LogLevel[LogLevel["INFO"] = 1] = "INFO";
    LogLevel[LogLevel["ERROR"] = 2] = "ERROR";
})(LogLevel || (LogLevel = {}));
var LogService = /** @class */ (function () {
    function LogService() {
        this.minimumLevel = LogLevel.INFO;
    }
    LogService.prototype.logInfoMessage = function (message) {
        this.logMessage(LogLevel.INFO, message);
    };
    LogService.prototype.logDebugMessage = function (message) {
        this.logMessage(LogLevel.DEBUG, message);
    };
    LogService.prototype.logErrorMessage = function (message) {
        this.logMessage(LogLevel.ERROR, message);
    };
    LogService.prototype.logMessage = function (level, message) {
        if (level >= this.minimumLevel) {
            console.log("Message (" + LogLevel[level] + "): " + message);
        }
    };
    LogService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
    ], LogService);
    return LogService;
}());



/***/ }),

/***/ "./src/app/common/structure.directive.ts":
/*!***********************************************!*\
  !*** ./src/app/common/structure.directive.ts ***!
  \***********************************************/
/*! exports provided: PaStructureDirective */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PaStructureDirective", function() { return PaStructureDirective; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var PaStructureDirective = /** @class */ (function () {
    function PaStructureDirective(container, template) {
        this.container = container;
        this.template = template;
    }
    PaStructureDirective.prototype.ngOnChanges = function (changes) {
        var change = changes["expressionResult"];
        if (!change.isFirstChange() && !change.currentValue) {
            this.container.clear();
        }
        else if (change.currentValue) {
            this.container.createEmbeddedView(this.template);
        }
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])("paIf"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Boolean)
    ], PaStructureDirective.prototype, "expressionResult", void 0);
    PaStructureDirective = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({
            selector: "[paIf]"
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewContainerRef"], _angular_core__WEBPACK_IMPORTED_MODULE_1__["TemplateRef"]])
    ], PaStructureDirective);
    return PaStructureDirective;
}());



/***/ }),

/***/ "./src/app/common/twoway.directive.ts":
/*!********************************************!*\
  !*** ./src/app/common/twoway.directive.ts ***!
  \********************************************/
/*! exports provided: PaModel */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PaModel", function() { return PaModel; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var PaModel = /** @class */ (function () {
    function PaModel() {
        this.direction = "None";
        this.fieldValue = "";
        this.update = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
    }
    PaModel.prototype.ngOnChanges = function (changes) {
        var change = changes["modelProperty"];
        if (change.currentValue != this.fieldValue) {
            this.fieldValue = changes["modelProperty"].currentValue || "";
            this.direction = "Model";
        }
    };
    PaModel.prototype.updateValue = function (newValue) {
        this.fieldValue = newValue;
        this.update.emit(newValue);
        this.direction = "Element";
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])("paModel"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
    ], PaModel.prototype, "modelProperty", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostBinding"])("value"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
    ], PaModel.prototype, "fieldValue", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])("paModelChange"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PaModel.prototype, "update", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostListener"])("input", ["$event.target.value"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Function),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [String]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:returntype", void 0)
    ], PaModel.prototype, "updateValue", null);
    PaModel = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({
            selector: "input[paModel]",
            exportAs: "paModel"
        })
    ], PaModel);
    return PaModel;
}());



/***/ }),

/***/ "./src/app/components/component.ts":
/*!*****************************************!*\
  !*** ./src/app/components/component.ts ***!
  \*****************************************/
/*! exports provided: ProductComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProductComponent", function() { return ProductComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ProductComponent = /** @class */ (function () {
    function ProductComponent() {
    }
    ProductComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: "app",
            template: __webpack_require__(/*! ./template.html */ "./src/app/components/template.html")
        })
    ], ProductComponent);
    return ProductComponent;
}());



/***/ }),

/***/ "./src/app/components/components.module.ts":
/*!*************************************************!*\
  !*** ./src/app/components/components.module.ts ***!
  \*************************************************/
/*! exports provided: ComponentsModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ComponentsModule", function() { return ComponentsModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _common_common_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../common/common.module */ "./src/app/common/common.module.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _discountDisplay_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./discountDisplay.component */ "./src/app/components/discountDisplay.component.ts");
/* harmony import */ var _discountEditor_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./discountEditor.component */ "./src/app/components/discountEditor.component.ts");
/* harmony import */ var _productForm_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./productForm.component */ "./src/app/components/productForm.component.ts");
/* harmony import */ var _productTable_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./productTable.component */ "./src/app/components/productTable.component.ts");
/* harmony import */ var _component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./component */ "./src/app/components/component.ts");










var ComponentsModule = /** @class */ (function () {
    function ComponentsModule() {
    }
    ComponentsModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [_angular_platform_browser__WEBPACK_IMPORTED_MODULE_2__["BrowserModule"], _angular_forms__WEBPACK_IMPORTED_MODULE_4__["FormsModule"], _angular_forms__WEBPACK_IMPORTED_MODULE_4__["ReactiveFormsModule"], _common_common_module__WEBPACK_IMPORTED_MODULE_3__["CommonModule"]],
            declarations: [_component__WEBPACK_IMPORTED_MODULE_9__["ProductComponent"], _discountDisplay_component__WEBPACK_IMPORTED_MODULE_5__["PaDiscountDisplayComponent"], _discountEditor_component__WEBPACK_IMPORTED_MODULE_6__["PaDiscountEditorComponent"],
                _productForm_component__WEBPACK_IMPORTED_MODULE_7__["ProductFormComponent"], _productTable_component__WEBPACK_IMPORTED_MODULE_8__["ProductTableComponent"]],
            exports: [_component__WEBPACK_IMPORTED_MODULE_9__["ProductComponent"], _productForm_component__WEBPACK_IMPORTED_MODULE_7__["ProductFormComponent"], _productTable_component__WEBPACK_IMPORTED_MODULE_8__["ProductTableComponent"]]
        })
    ], ComponentsModule);
    return ComponentsModule;
}());



/***/ }),

/***/ "./src/app/components/discountDisplay.component.ts":
/*!*********************************************************!*\
  !*** ./src/app/components/discountDisplay.component.ts ***!
  \*********************************************************/
/*! exports provided: PaDiscountDisplayComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PaDiscountDisplayComponent", function() { return PaDiscountDisplayComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _common_discount_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../common/discount.service */ "./src/app/common/discount.service.ts");



var PaDiscountDisplayComponent = /** @class */ (function () {
    function PaDiscountDisplayComponent(discounter) {
        this.discounter = discounter;
    }
    PaDiscountDisplayComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: "paDiscountDisplay",
            template: "<div class=\"bg-info p-a-1\">The discount is {{discounter.discount}}</div>"
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_common_discount_service__WEBPACK_IMPORTED_MODULE_2__["DiscountService"]])
    ], PaDiscountDisplayComponent);
    return PaDiscountDisplayComponent;
}());



/***/ }),

/***/ "./src/app/components/discountEditor.component.ts":
/*!********************************************************!*\
  !*** ./src/app/components/discountEditor.component.ts ***!
  \********************************************************/
/*! exports provided: PaDiscountEditorComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PaDiscountEditorComponent", function() { return PaDiscountEditorComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _common_discount_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../common/discount.service */ "./src/app/common/discount.service.ts");



var PaDiscountEditorComponent = /** @class */ (function () {
    function PaDiscountEditorComponent(discounter) {
        this.discounter = discounter;
    }
    PaDiscountEditorComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: "paDiscountEditor",
            template: "<div class=\"form-group\">\n                    <label>Discount</label>\n                    <input [(ngModel)]=\"discounter.discount\"\n                    class=\"form-control\" type=\"number\" />\n               </div>"
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_common_discount_service__WEBPACK_IMPORTED_MODULE_2__["DiscountService"]])
    ], PaDiscountEditorComponent);
    return PaDiscountEditorComponent;
}());



/***/ }),

/***/ "./src/app/components/productForm.component.html":
/*!*******************************************************!*\
  !*** ./src/app/components/productForm.component.html ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<form novalidate [formGroup]=\"form\" (ngSubmit)=\"submittedForm(form)\">\r\n    <div class=\"form-group\" *ngFor=\"let control of form.productControls\">\r\n        <label>{{control.label}}</label>\r\n        <input class=\"form-control\"\r\n              [(ngModel)]=\"newProduct[control.modelProperty]\"\r\n              name=\"{{control.modelProperty}}\"\r\n              formControlName=\"{{control.modelProperty}}\" />\r\n        <ul class=\"text-danger list-unstyled\"\r\n                *ngIf=\"(formSubmitted || control.dirty) && !control.valid\">\r\n            <li *ngFor=\"let error of control.getValidationMessages()\">\r\n                {{error}}\r\n            </li>\r\n        </ul>\r\n    </div>\r\n    <button class=\"btn btn-primary\" type=\"submit\"\r\n        [disabled]=\"formSubmitted && !form.valid\"\r\n        [class.btn-secondary]=\"formSubmitted && !form.valid\">Create</button>\r\n</form>\r\n"

/***/ }),

/***/ "./src/app/components/productForm.component.ts":
/*!*****************************************************!*\
  !*** ./src/app/components/productForm.component.ts ***!
  \*****************************************************/
/*! exports provided: ProductFormComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProductFormComponent", function() { return ProductFormComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _model_product_model__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../model/product.model */ "./src/app/model/product.model.ts");
/* harmony import */ var _model_form_model__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../model/form.model */ "./src/app/model/form.model.ts");
/* harmony import */ var _model_repository_model__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../model/repository.model */ "./src/app/model/repository.model.ts");





var ProductFormComponent = /** @class */ (function () {
    function ProductFormComponent(model) {
        this.model = model;
        this.form = new _model_form_model__WEBPACK_IMPORTED_MODULE_3__["ProductFormGroup"]();
        this.newProduct = new _model_product_model__WEBPACK_IMPORTED_MODULE_2__["Product"]();
        this.formSubmitted = false;
    }
    //@Output("paNewProduct")
    //newProductEvent = new EventEmitter<Product>();
    ProductFormComponent.prototype.submittedForm = function (form) {
        this.formSubmitted = true;
        if (form.valid) {
            //this.newProductEvent.emit(this.newProduct);
            this.model.saveProduct(this.newProduct);
            this.newProduct = new _model_product_model__WEBPACK_IMPORTED_MODULE_2__["Product"]();
            this.form.reset();
            this.formSubmitted = false;
        }
    };
    ProductFormComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: "paProductForm",
            template: __webpack_require__(/*! ./productForm.component.html */ "./src/app/components/productForm.component.html"),
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_model_repository_model__WEBPACK_IMPORTED_MODULE_4__["Model"]])
    ], ProductFormComponent);
    return ProductFormComponent;
}());



/***/ }),

/***/ "./src/app/components/productTable.component.html":
/*!********************************************************!*\
  !*** ./src/app/components/productTable.component.html ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\r\n<table class=\"table table-sm table-bordered table-striped\">\r\n    <tr><th></th><th>Name</th><th>Category</th><th>Price</th><th>Discount</th><th></th></tr>\r\n    <tr *paFor=\"let item of getProducts(); let i = index; let odd = odd;\r\n            let even = even\" [class.bg-info]=\"odd\" [class.bg-warning]=\"even\">\r\n        <td style=\"vertical-align:middle\">{{i + 1}}</td>\r\n        <td style=\"vertical-align:middle\">{{item.name}}</td>\r\n        <td style=\"vertical-align:middle\">{{item.category}}</td>\r\n        <td style=\"vertical-align:middle\">{{item.price | discount | currency:\"USD\":true }}</td>\r\n        <td style=\"vertical-align:middle\" [pa-price]=\"item.price\"\r\n                 #discount=\"discount\">\r\n            {{ discount.discountAmount | currency:\"USD\":true }}\r\n        </td>\r\n        <td class=\"text-md-center\">\r\n            <button class=\"btn btn-danger btn-sm\" (click)=\"deleteProduct(item.id)\">Delete</button>\r\n        </td>\r\n    </tr>\r\n</table>\r\n\r\n<!--<paDiscountEditor></paDiscountEditor>-->\r\n<!--<paDiscountDisplay></paDiscountDisplay>-->\r\n"

/***/ }),

/***/ "./src/app/components/productTable.component.ts":
/*!******************************************************!*\
  !*** ./src/app/components/productTable.component.ts ***!
  \******************************************************/
/*! exports provided: ProductTableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProductTableComponent", function() { return ProductTableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _model_repository_model__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../model/repository.model */ "./src/app/model/repository.model.ts");



var ProductTableComponent = /** @class */ (function () {
    //@Input("model")
    //dataModel: Model;
    function ProductTableComponent(dataModel) {
        this.dataModel = dataModel;
        this.dateObject = new Date(2020, 1, 20);
        this.dateString = "2020-02-20T00:00:00.000Z";
        this.dateNumber = 1582156800000;
    }
    ProductTableComponent.prototype.getProduct = function (key) {
        return this.dataModel.getProduct(key);
    };
    ProductTableComponent.prototype.getProducts = function () {
        return this.dataModel.getProducts();
    };
    ProductTableComponent.prototype.deleteProduct = function (key) {
        this.dataModel.deleteProduct(key);
    };
    ProductTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: "paProductTable",
            template: __webpack_require__(/*! ./productTable.component.html */ "./src/app/components/productTable.component.html")
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_model_repository_model__WEBPACK_IMPORTED_MODULE_2__["Model"]])
    ], ProductTableComponent);
    return ProductTableComponent;
}());



/***/ }),

/***/ "./src/app/components/template.html":
/*!******************************************!*\
  !*** ./src/app/components/template.html ***!
  \******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<style>\n    input.ng-dirty.ng-invalid { border: 2px solid #ff0000 }\n    input.ng-dirty.ng-valid { border: 2px solid #6bc502 }\n</style>\n\n<div class=\"row\">\n    <div class=\"col-sm col-md-4\">\n        <paProductForm></paProductForm>\n    </div>\n    <div class=\"col-sm col-md-8\">\n        <paProductTable></paProductTable>        \n    </div>\n</div>\n"

/***/ }),

/***/ "./src/app/model/datasource.model.ts":
/*!*******************************************!*\
  !*** ./src/app/model/datasource.model.ts ***!
  \*******************************************/
/*! exports provided: SimpleDataSource */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SimpleDataSource", function() { return SimpleDataSource; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _product_model__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./product.model */ "./src/app/model/product.model.ts");



var SimpleDataSource = /** @class */ (function () {
    function SimpleDataSource() {
        this.data = new Array(new _product_model__WEBPACK_IMPORTED_MODULE_2__["Product"](1, "Kayak", "Watersports", 275), new _product_model__WEBPACK_IMPORTED_MODULE_2__["Product"](2, "Lifejacket", "Watersports", 48.95), new _product_model__WEBPACK_IMPORTED_MODULE_2__["Product"](3, "Soccer Ball", "Soccer", 19.50), new _product_model__WEBPACK_IMPORTED_MODULE_2__["Product"](4, "Corner Flags", "Soccer", 34.95), new _product_model__WEBPACK_IMPORTED_MODULE_2__["Product"](5, "Thinking Cap", "Chess", 16));
    }
    SimpleDataSource.prototype.getData = function () {
        return this.data;
    };
    SimpleDataSource = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], SimpleDataSource);
    return SimpleDataSource;
}());



/***/ }),

/***/ "./src/app/model/form.model.ts":
/*!*************************************!*\
  !*** ./src/app/model/form.model.ts ***!
  \*************************************/
/*! exports provided: ProductFormControl, ProductFormGroup */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProductFormControl", function() { return ProductFormControl; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProductFormGroup", function() { return ProductFormGroup; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");


var ProductFormControl = /** @class */ (function (_super) {
    tslib__WEBPACK_IMPORTED_MODULE_0__["__extends"](ProductFormControl, _super);
    function ProductFormControl(label, property, value, validator) {
        var _this = _super.call(this, value, validator) || this;
        _this.label = label;
        _this.modelProperty = property;
        return _this;
    }
    ProductFormControl.prototype.getValidationMessages = function () {
        var messages = [];
        if (this.errors) {
            for (var errorName in this.errors) {
                switch (errorName) {
                    case "required":
                        messages.push("You must enter a " + this.label);
                        break;
                    case "minlength":
                        messages.push("A " + this.label + " must be at least " + this.errors['minlength'].requiredLength + " characters");
                        break;
                    case "maxlength":
                        messages.push("A " + this.label + " must be no more than " + this.errors['maxlength'].requiredLength + " characters");
                        break;
                    case "pattern":
                        messages.push("The " + this.label + " contains illegal characters");
                        break;
                }
            }
        }
        return messages;
    };
    return ProductFormControl;
}(_angular_forms__WEBPACK_IMPORTED_MODULE_1__["FormControl"]));

var ProductFormGroup = /** @class */ (function (_super) {
    tslib__WEBPACK_IMPORTED_MODULE_0__["__extends"](ProductFormGroup, _super);
    function ProductFormGroup() {
        return _super.call(this, {
            name: new ProductFormControl("Name", "name", "", _angular_forms__WEBPACK_IMPORTED_MODULE_1__["Validators"].required),
            category: new ProductFormControl("Category", "category", "", _angular_forms__WEBPACK_IMPORTED_MODULE_1__["Validators"].compose([_angular_forms__WEBPACK_IMPORTED_MODULE_1__["Validators"].required,
                _angular_forms__WEBPACK_IMPORTED_MODULE_1__["Validators"].pattern("^[A-Za-z]+$"),
                _angular_forms__WEBPACK_IMPORTED_MODULE_1__["Validators"].minLength(3),
                _angular_forms__WEBPACK_IMPORTED_MODULE_1__["Validators"].maxLength(10)])),
            price: new ProductFormControl("Price", "price", "", _angular_forms__WEBPACK_IMPORTED_MODULE_1__["Validators"].compose([_angular_forms__WEBPACK_IMPORTED_MODULE_1__["Validators"].required, _angular_forms__WEBPACK_IMPORTED_MODULE_1__["Validators"].pattern("^[0-9\.]+$")]))
        }) || this;
    }
    Object.defineProperty(ProductFormGroup.prototype, "productControls", {
        get: function () {
            var _this = this;
            return Object.keys(this.controls)
                .map(function (k) { return _this.controls[k]; });
        },
        enumerable: true,
        configurable: true
    });
    ProductFormGroup.prototype.getFormValidationMessages = function (form) {
        var messages = [];
        this.productControls.forEach(function (c) { return c.getValidationMessages()
            .forEach(function (m) { return messages.push(m); }); });
        return messages;
    };
    return ProductFormGroup;
}(_angular_forms__WEBPACK_IMPORTED_MODULE_1__["FormGroup"]));



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
/* harmony import */ var _datasource_model__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./datasource.model */ "./src/app/model/datasource.model.ts");
/* harmony import */ var _repository_model__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./repository.model */ "./src/app/model/repository.model.ts");




var ModelModule = /** @class */ (function () {
    function ModelModule() {
    }
    ModelModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            providers: [_repository_model__WEBPACK_IMPORTED_MODULE_3__["Model"], _datasource_model__WEBPACK_IMPORTED_MODULE_2__["SimpleDataSource"]]
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
/* harmony import */ var _datasource_model__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./datasource.model */ "./src/app/model/datasource.model.ts");



var Model = /** @class */ (function () {
    function Model(dataSource) {
        var _this = this;
        this.dataSource = dataSource;
        this.locator = function (p, id) { return p.id == id; };
        //this.dataSource = new SimpleDataSource();
        this.products = new Array();
        this.dataSource.getData().forEach(function (p) { return _this.products.push(p); });
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
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_datasource_model__WEBPACK_IMPORTED_MODULE_2__["SimpleDataSource"]])
    ], Model);
    return Model;
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

module.exports = __webpack_require__(/*! C:\Users\foxland\Dev\Lessons\Lessons3_Angular\example\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map