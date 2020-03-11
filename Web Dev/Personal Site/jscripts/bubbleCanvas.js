

function color(r,g,b,a){
	return "rgba("+r+","+g+","+b+","+a+")";
}

var canvas = document.getElementById('bubbles');
var c = canvas.getContext('2d');


var cOffset = $(".post").innerWidth() - $(".post").width();
canvas.width = canvas.parentElement.getBoundingClientRect().width - cOffset;
canvas.height = canvas.width * 0.5;
var width = canvas.width;
var height = canvas.height;

//purply color
c.strokeStyle = 'rgba(110,110,255, 1)';
c.lineWidth = 3;
c.fillStyle = 'rgba(255,100,255, 0.7)';

// bubbles from bubbles.js
var bubbles = [];
var numBubbles = 100;
var colors = [color(255,0,0,1), color(0,255,0,1), color(0,0,255,1)];

for(var i = 0; i < numBubbles; ++i){
	bubbles.push(new Bubble());
}

function animate(){
	requestAnimationFrame(animate);
	c.clearRect(0, 0, canvas.width, canvas.height);

	for (var i = bubbles.length - 1; i >= 0; i--) {
		var colorScale = (bubbles[i].x/2)+50;
		bubbles[i].color = color((colorScale+400)%255, (colorScale+300)%512*(bubbles[i].x/255) , (colorScale+100)%512*(bubbles[i].x/255),1);
		bubbles[i].draw();
		bubbles[i].update();
	}
}

animate();

// generates new bubbles
$("#generate").click(function(){
	bubbles = [];
	for(var i = 0; i < numBubbles; ++i){
		bubbles.push(new Bubble());
	}
});

// generates new bubbles after input change
$("#numBubbles").change(function(){
	// console.log($("#numBubbles").val());
	numBubbles = $("#numBubbles").val();

	bubbles = [];
	for(var i = 0; i < numBubbles; ++i){
		bubbles.push(new Bubble());
	}
})

// resize canvas with window resize
$(window).resize(function() {
	cOffset = $(".post").innerWidth() - $(".post").width();
	canvas.width = canvas.parentElement.getBoundingClientRect().width - cOffset;
	canvas.height = canvas.width * 0.5;
	width = canvas.width;
	height = canvas.height;
	c.strokeStyle = 'rgba(110,110,255, 1)';
	c.lineWidth = 3;
	c.fillStyle = 'rgba(255,100,255, 0.7)';
});

$(document).ready(function() {
	// console.log("ready");
	$("#numBubbles").val(numBubbles);
});
// c.fillRect(20, 20, 100, 100);

//lines
// c.beginPath();
// c.moveTo(120, 20);
// c.lineTo(200, 100);
// c.lineTo(300, 100);
// c.stroke();

//cirlces
// c.beginPath();
// c.arc(400, 100, 50, 0, Math.PI, true);
// c.stroke();

// for (var i = 0; i < 3; ++i){
// 	var x = Math.random() * (canvas.width - 100) + 50;
// 	var y = Math.random() * (canvas.height - 100) + 50;
// 	c.beginPath();
// 	c.arc(x, y, 50, 0, Math.PI*2, false);
// 	c.stroke();

// }