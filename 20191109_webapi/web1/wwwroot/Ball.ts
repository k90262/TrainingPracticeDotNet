// pre-installation:
// 1. nodejs (npm), 2. npm install -g typescript
//
// reference site:
// typescript.org
// typescriptlang.org
//
// compile command (.ts -> .js):
// tsc .\wwwroot\Ball.ts

class Ball {

    constructor(public ctx:CanvasRenderingContext2D, public x: number,public  y: number,public  r: number,public  c: string, public dx: number, public dy: number){

    }

    move() {
        this.x += this.dx;
        this.y += this.dy;
    }

    show() {
        console.log(`(${this.x}, ${this.y})`);
        this.ctx.beginPath();
        this.ctx.arc(this.x, this.y, this.r, 0, 2*Math.PI);
        this.ctx.closePath();

        this.ctx.fillStyle = this.c;
        this.ctx.fill();
    }
}
// test only
//
// let obj = new Ball(300, 200, 50, "blue", 5, 10);
// for(var i=0; i<10; i++) {
//     obj.move();
//     obj.show();
// }
// alert(obj.c);
