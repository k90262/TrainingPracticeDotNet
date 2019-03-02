class Car {
    constructor(public speed: number) {

    }
    speedUp(inc: number) {
        this.speed += inc;
    }
    showSpeed() {
        alert(this.speed);
    }
}

class RaceCar extends Car {
    constructor(public name: string, speed: number) {
        super(speed);
    }
    speedUp(inc: number) {
        super.speedUp(inc);
        this.speed += inc;
    }
    showSpeed() {
        alert(this.name + " : " + this.speed);
    }
}

let obj = new RaceCar("Lambo", 50);
obj.speedUp(50);
obj.showSpeed();
