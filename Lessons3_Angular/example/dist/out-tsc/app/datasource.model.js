import { Product } from "./product.model";
var SimpleDataSource = /** @class */ (function () {
    function SimpleDataSource() {
        this.data = new Array(new Product(1, "Kayak", "Watersports", 275), new Product(2, "Lifejacket", "Watersports", 48.95), new Product(3, "Soccer Ball", "Soccer", 19.50), new Product(4, "Corner Flags", "Soccer", 34.95), new Product(5, "Thinking Cap", "Chess", 16));
    }
    SimpleDataSource.prototype.getData = function () {
        return this.data;
    };
    return SimpleDataSource;
}());
export { SimpleDataSource };
//# sourceMappingURL=datasource.model.js.map