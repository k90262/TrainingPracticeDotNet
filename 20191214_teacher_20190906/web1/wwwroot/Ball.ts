class Ball {
    constructor(public ctx: CanvasRenderingContext2D, public x: number, public y: number, public r:number, public c: string, public dx: number, public dy: number) {
    }

    show() {
        this.ctx.beginPath();
        this.ctx.arc(this.x, this.y, this.r, 0, 2 * Math.PI);
        this.ctx.closePath();
        this.ctx.fillStyle = this.c;
        this.ctx.fill(); 
    }

    move() {
        this.x += this.dx;
        this.y += this.dy;
        if (this.x - this.r <= 0 || this.x + this.r >= this.ctx.canvas.width) this.dx = -this.dx;
        if (this.y - this.r <= 0 || this.y + this.r >= this.ctx.canvas.height) this.dy = -this.dy;
    }

}