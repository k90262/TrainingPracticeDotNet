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
    function Ball(ctx, x, y, r, c, dx, dy) {
        this.ctx = ctx;
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
        // collision and rebound
        if (this.x - this.r <= 0 || this.x + this.r >= this.ctx.canvas.width)
            this.dx = -this.dx;
        if (this.y - this.r <= 0 || this.y + this.r >= this.ctx.canvas.height)
            this.dy = -this.dy;
    };
    Ball.prototype.show = function () {
        console.log("(" + this.x + ", " + this.y + ")");
        this.ctx.beginPath();
        this.ctx.arc(this.x, this.y, this.r, 0, 2 * Math.PI);
        this.ctx.closePath();
        this.ctx.fillStyle = this.c;
        this.ctx.fill();
    };
    return Ball;
}());
// test only
//
// let obj = new Ball(300, 200, 50, "blue", 5, 10);
// for(var i=0; i<10; i++) {
//     obj.move();
//     obj.show();
// }
// alert(obj.c);
