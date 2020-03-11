
class Graph {
	constructor(x, y, w, h, numBars){
		this.x = x;
		this.y = y;
		this.w = w;
		this.h = h;
		this.bars = [];
		this.numBars = numBars;
		this.barWidth = w/numBars;
		this.initH = height;
		this.scale = this.h / h;
	}

	setHeights(heights){
		for (var i = 0; i < heights.length; ++i){
			this.bars[i].setHeight(heights[i]);
		}
	}

	draw() {
		for (var i = 0; i < this.bars.length; ++i) {
			this.bars[i].draw();
		}
	}

	update(){
		this.y = height;
		this.barWidth = width/numBars;
		this.scale = height/this.h;
		this.h = height;
		// console.log("scale " + this.scale + " height "
		// 	+ height + " thisHeight " + this.h);
		for (var i = 0; i < this.bars.length; ++i) {
			// console.log("bars[ " + i + "].x = " + this.bars[i].x);
			this.bars[i].x = this.barWidth*i;
			this.bars[i].y = this.y;
			this.bars[i].w = this.barWidth;
			this.bars[i].h = this.bars[i].h * this.scale;
		}
	}

	randomBars(numBars) {
		var randHeight;
		this.numBars = numBars;
		this.bars = [];
		for(var i = 0; i < this.numBars; i++){
			randHeight = Math.random() *this.h;
			this.bars.push(new Bar(this.x+this.barWidth*i, this.y,
				this.barWidth, randHeight));
		}
	}

	setColor(color){
		for (var i = 0; i < this.bars.length; ++i){
			this.bars[i].color = color;
		}
	}
}

function color(r,g,b,a){
	return "rgba("+r+","+g+","+b+","+a+")";
}