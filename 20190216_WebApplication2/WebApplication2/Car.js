var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Car = (function () {
    function Car(speed) {
        this.speed = speed;
    }
    Car.prototype.speedUp = function (inc) {
        this.speed += inc;
    };
    Car.prototype.showSpeed = function () {
        alert(this.speed);
    };
    return Car;
}());
var RaceCar = (function (_super) {
    __extends(RaceCar, _super);
    function RaceCar(name, speed) {
        var _this = _super.call(this, speed) || this;
        _this.name = name;
        return _this;
    }
    RaceCar.prototype.speedUp = function (inc) {
        _super.prototype.speedUp.call(this, inc);
        this.speed += inc;
    };
    RaceCar.prototype.showSpeed = function () {
        alert(this.name + " : " + this.speed);
    };
    return RaceCar;
}(Car));
var obj = new RaceCar("Lambo", 50);
obj.speedUp(50);
obj.showSpeed();
//# sourceMappingURL=Car.js.map