class Ball {

    constructor(public x: number,public  y: number,public  r: number,public  c: string){

    }
}

let obj = new Ball(300, 200, 50, "blue");
alert(obj.c);
