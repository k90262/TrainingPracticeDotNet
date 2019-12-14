class Car {
    speed: number;

    constructor(init_speed: number) {
        this.speed = init_speed;
    }

    speedUp(inc: number) {
        this.speed += inc;
    }

    show() {
        alert(this.speed);
    }
}