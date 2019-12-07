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

    constructor(public x: number,public  y: number,public  r: number,public  c: string, public dx: number, public dy: number){

    }

    move() {
        this.x += this.dx;
        this.y += this.dy;
    }

    show() {
        console.log(`(${this.x}, ${this.y})`);
    }
}

let obj = new Ball(300, 200, 50, "blue", 5, 10);
for(var i=0; i<10; i++) {
    obj.move();
    obj.show();
}
alert(obj.c);
