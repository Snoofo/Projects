class Bar {
	constructor(x, y, w, h){
		this.x = x;
		this.y = y;
		this.w = w;
		this.h = h;
		this.color = color(255,100,255, 0.7);
	}

	draw() {
		c.fillStyle = this.color;
		c.fillRect(this.x, this.y, this.w, -this.h);
		c.beginPath();
		c.rect(this.x, this.y, this.w, -this.h);
		c.stroke();
		c.closePath();
	}

	setColor(color){
		this.color = color;
	}

	setHeight(h){
		this.h = h;
	}
}