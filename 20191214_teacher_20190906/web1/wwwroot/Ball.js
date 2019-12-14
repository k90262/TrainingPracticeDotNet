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
    Ball.prototype.show = function () {
        this.ctx.beginPath();
        this.ctx.arc(this.x, this.y, this.r, 0, 2 * Math.PI);
        this.ctx.closePath();
        this.ctx.fillStyle = this.c;
        this.ctx.fill();
    };
    Ball.prototype.move = function () {
        this.x += this.dx;
        this.y += this.dy;
        if (this.x - this.r <= 0 || this.x + this.r >= this.ctx.canvas.width)
            this.dx = -this.dx;
        if (this.y - this.r <= 0 || this.y + this.r >= this.ctx.canvas.height)
            this.dy = -this.dy;
    };
    return Ball;
}());
