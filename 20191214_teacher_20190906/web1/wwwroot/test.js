var Car = /** @class */ (function () {
    function Car(init_speed) {
        this.speed = init_speed;
    }
    Car.prototype.speedUp = function (inc) {
        this.speed += inc;
    };
    Car.prototype.show = function () {
        alert(this.speed);
    };
    return Car;
}());
