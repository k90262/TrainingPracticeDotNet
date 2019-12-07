var Ball = /** @class */ (function () {
    function Ball(x, y, r, c) {
        this.x = x;
        this.y = y;
        this.r = r;
        this.c = c;
    }
    return Ball;
}());
var obj = new Ball(300, 200, 50, "blue");
alert(obj.c);
