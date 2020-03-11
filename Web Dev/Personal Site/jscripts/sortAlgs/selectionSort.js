

async function sortSelection(graph){
	var min;
	var tempColor = graph.bars[0].color;
	for (var i = 0; i < graph.bars.length; ++i){
		min = i;
		graph.bars[min].color = color(255,0,0,1);
		// graph.bars[j].color = color(255,0,0,0.5);
		updateCanvas();
		for (var j = i+1; j < graph.bars.length; j++){
			if (cancel){
				cancel = false;
				return;
			}
			graph.bars[j].color = color(255,0,0, 0.5);
			updateCanvas();
			await sleep(shuffleDelay);

			// console.log("in selection");
			if (graph.bars[j].h < graph.bars[min].h){
				// console.log(graph.bars[j].h +" less than "+graph.bars[min].h);
				graph.bars[min].color = tempColor;
				min = j;
				graph.bars[min].color = color(255,0,0,1);
			}
			else {
				graph.bars[j].color = tempColor;
			}
			updateCanvas();
			await sleep(shuffleDelay);
		}
		updateCanvas();
		await sleep(displayDelay);
		graph.bars[min].color = tempColor;
		swapBar(graph, i, min);
		graph.bars[i].color = color(0,255,0,1);
		updateCanvas();
		await sleep(displayDelay);
		graph.bars[i].color = color(0,255,0,0.5);
		updateCanvas();
	}
	finished();
}