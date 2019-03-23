class Ball {
    constructor(public ctx: CanvasRenderingContext2D, public x:number, public y:number, public r:number, public color: string, public dx:number, public dy:number) {

    }

    show() {
        this.ctx.beginPath();
        this.ctx.arc(this.x, this.y, this.r, 0, Math.PI * 2);
        this.ctx.closePath();
        this.ctx.fillStyle = this.color;
        this.ctx.fill();
    }

    move() {
        this.x += this.dx;
        this.y += this.dy;

        if (this.y - this.r <= 0 || this.y + this.r >= this.ctx.canvas.height) this.dy = -this.dy;
        if (this.x - this.r <= 0 || this.x + this.r >= this.ctx.canvas.width) this.dx = -this.dx;
    }
}
