
// create new canvas element
var canvas = document.createElement('canvas');
canvas.id = "sorting";

// get div element to store canvas in
var container = document.getElementById('graph');
container.appendChild(canvas);

var c = canvas.getContext('2d');
// get parent element's margin
var cOffset = $(container).innerWidth() - $(container).width();
// set canvas width to edge of parent margin
canvas.width = canvas.parentElement.getBoundingClientRect().width - cOffset;
canvas.height = canvas.width * 0.5;
// set global variables for canvas dimensions
var width = canvas.width;
var height = canvas.height;

// function names to be called dynamically
var functions = {
	insertion: sortInsertion,
	bubble: sortBubble,
	selection: sortSelection,
	quick: sortQuick
};
// default sort
var currentSort = "insertion";

// delays in milliseconds
var shuffleDelay = 10;
var displayDelay = 300;
var isSorting = false;

// set line and fill colours: default purply color
c.strokeStyle = 'rgba(110,110,255, 1)';
c.fillStyle = 'rgba(255,100,255, 0.7)';
var lineWidth = 1;
c.lineWidth = lineWidth;

// default number of bars in graph
var numBars = 20;
var graph = new Graph(0, height, width, height, numBars);

// var heights = [100,150,200,250];
// graph.setHeights(heights);
var i = 1;
var cancel = false;

function swapBar(graph, i, j){
	// console.log("i.x before "+graph.bars[i].h);
	// console.log("j.x before "+graph.bars[j].h);
	var temp = graph.bars[i];
	graph.bars[i] = graph.bars[j];
	graph.bars[j] = temp;
	// console.log("i.x after "+graph.bars[i].h);
	// console.log("j.x after "+graph.bars[j].h);
}

// refresh canvas with new graph
// checks if sorting is already happening
// and changes button text to respective name
function restartGraph(){
	if (!isSorting){
		isSorting = true;
		$("#generate").text('Stop');
		$("#displayText").hide();
		// console.log("shuffleDelay" + shuffleDelay);

		setNumBars(numBars = $("#numBars").val());
		graph.randomBars(numBars);
		resetSorting();
		var promise = functions[currentSort](graph,0,graph.bars.length-1);
		promise.then(function(){
			isSorting = false;
			cancel = false;
			$("#generate").text('Generate');
			// console.log("finished promise");
		});
	}
	else {
		cancel = true;
		isSorting = false;
		// console.log("sorting is false");
	}
}

function updateCanvas(){
	c.clearRect(0, 0, width, height);
	graph.update();	
	graph.draw();
}

function resetSorting(){
	i = 1;
}

function setNumBars(numBars){
	if (numBars >= 300){
		c.lineWidth = 0;
		shuffleDelay = 0;
		displayDelay = 100;
	}
	else if (numBars >= 100){
		shuffleDelay = 0;
		displayDelay = 200;
	}
	else if (numBars > 50){
		shuffleDelay = 5;
	}
	else {
		shuffleDelay = 10;
	}
}

function finished(){
	graph.setColor(color(0,255,0,1));
	updateCanvas();
	$("#displayText").show();
	$("#generate").text('Generate');
}

function sleep(ms) {
  return new Promise(resolve => setTimeout(resolve, ms));
}

// function animate(){
// 	// requestAnimationFrame(animate);
// 	// c.clearRect(0, 0, width, height);

// }
// animate();

// action on generate button click
// refresh graph
$("#generate").click(function(){
	restartGraph();
});

// action when enter (key '13') is pressed in numBars input
// refresh graph
$("#numBars").on('keypress', function(e){
	// console.log($("#numBars").val());
	if (e.which == 13){
		restartGraph();
	}
});

// when insertion option is clicked
$("#insertion").click(function(){
	currentSort = "insertion";
	$("#insertion").css("background-color", "white");
	$("#bubble").css("background-color", "transparent");
	$("#selection").css("background-color", "transparent");
	$("#quick").css("background-color", "transparent");
	restartGraph();
});

// when bubble option is clicked
$("#bubble").click(function(){
	currentSort = "bubble";
	$("#insertion").css("background-color", "transparent");
	$("#bubble").css("background-color", "white");
	$("#selection").css("background-color", "transparent");
	$("#quick").css("background-color", "transparent");
	restartGraph();
});

// when selection option is clicked
$("#selection").click(function(){
	currentSort = "selection";
	$("#insertion").css("background-color", "transparent");
	$("#bubble").css("background-color", "transparent");
	$("#selection").css("background-color", "white");
	$("#quick").css("background-color", "transparent");
	restartGraph();
});

// when quick option is clicked
$("#quick").click(function(){
	currentSort = "quick";
	$("#insertion").css("background-color", "transparent");
	$("#bubble").css("background-color", "transparent");
	$("#selection").css("background-color", "transparent");
	$("#quick").css("background-color", "white");
	restartGraph();
});

// resize canvas and repaint when window resize
$(window).resize(function() {
	cOffset = $(".post").innerWidth() - $(".post").width();
	canvas.width = canvas.parentElement.getBoundingClientRect().width - cOffset;
	canvas.height = canvas.width * 0.5;
	width = canvas.width;
	height = canvas.height;
	c.strokeStyle = 'rgba(110,110,255, 1)';
	updateCanvas();
});

$(document).ready(function() {
	// console.log("ready");
	$("#displayText").hide();
	$("#insertion").css("background-color", "white");
	$("#numBars").val(numBars);
	restartGraph();
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
