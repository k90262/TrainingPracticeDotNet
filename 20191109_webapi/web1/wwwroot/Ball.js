// pre-installation:
// 1. nodejs (npm), 2. npm install -g typescript
//
// reference site:
// typescript.org
// typescriptlang.org
//
// compile command (.ts -> .js):
// tsc .\wwwroot\Ball.ts
var Ball = /** @class */ (function () {
    function Ball(x, y, r, c, dx, dy) {
        this.x = x;
        this.y = y;
        this.r = r;
        this.c = c;
        this.dx = dx;
        this.dy = dy;
    }
    Ball.prototype.move = function () {
        this.x += this.dx;
        this.y += this.dy;
    };
    Ball.prototype.show = function () {
        console.log("(" + this.x + ", " + this.y + ")");
    };
    return Ball;
}());
var obj = new Ball(300, 200, 50, "blue", 5, 10);
for (var i = 0; i < 10; i++) {
    obj.move();
    obj.show();
}
alert(obj.c);
