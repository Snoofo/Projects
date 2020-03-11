
class Bubble {
	constructor(){
		this.r = (Math.random() * 20) + 10;
		this.x = Math.random() * (canvas.width - this.r*2) + this.r;
		this.y = Math.random() * (canvas.height - this.r*2) + this.r;
		this.dx = Math.random() * 4 - 2;
		this.dy = Math.random() * 4 - 2;
		this.color = color(110,110,255, 1);
	}
	draw(){
		c.beginPath();
		c.strokeStyle = this.color;
		c.lineWidth = 2;
		c.arc(this.x, this.y, this.r, 0, Math.PI*2, true);
		c.stroke();
		c.closePath();

		// c.beginPath();
		// c.strokeStyle = color(255,255,255,0.3);
		// c.lineWidth = 1;
		// c.arc(this.x +(this.r/4), this.y -(this.r/4), this.r/2, 0, Math.PI*2, true);
		// c.stroke();
		// c.closePath();
	}
	update(){
		this.x += this.dx;
		this.y += this.dy;
		if (this.x + this.r > canvas.width || this.x - this.r < 0){
			this.dx = -this.dx;
		}
		if (this.y + this.r > canvas.height || this.y - this.r < 0){
			this.dy = -this.dy;
		}
	}
}