

async function sortBubble(graph){
	for (var i = 0; i < graph.bars.length; ++i){
		var j = 0;
		for (j; j < graph.bars.length - i-1; j++){
			if (cancel){
				cancel = false;
				return;
			}
			
			temp = graph.bars[j];
			tempColor = temp.color;
			temp.color = color(255,0,0,1);

			if (graph.bars[j].h > graph.bars[j+1].h){
				// console.log("before "+bar1.x);
				// console.log("before "+bar2.x);
				swapBar(graph, j, j+1);
				// console.log("after "+graph.bars[j].x);
				// console.log("after "+graph.bars[j+1].x);
			}
			updateCanvas();
			await sleep(shuffleDelay);
			temp.color = tempColor;
		}
		graph.bars[j].color = color(0,255,0,1);
		updateCanvas();
		await sleep(displayDelay);
		graph.bars[j].color = color(0,255,0,0.5);
	}
	finished();
}