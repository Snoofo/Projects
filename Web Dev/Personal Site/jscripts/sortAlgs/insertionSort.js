

async function sortInsertion(graph){
	var temp;
	var tempColor;
	var cmp;
	var tempBar;

	for (i; i < graph.bars.length; ++i){
		temp = graph.bars[i];
		tempColor = temp.color;
		// temp.color = color(255,0,0,1);
		cmp = i-1;
		// console.log("before while");
		tempBar = new Bar(temp.x, temp.y, temp.w, temp.h);
		tempBar.color = color(255,0,0,1);
		graph.bars[cmp].color = color(0,255,0,0.5);
		updateCanvas();
		tempBar.draw();
		await sleep(displayDelay);
		while (cmp >= 0 && temp.h < graph.bars[cmp].h){
			if (cancel){
				cancel = false;
				return;
			}
			// console.log("in first while");
			graph.bars[cmp + 1] = graph.bars[cmp];
			tempBar.x = graph.bars[cmp].x;
			updateCanvas();
			tempBar.draw();
			await sleep(shuffleDelay);
			// console.log("in second while");
			cmp--;
		}
		temp.color = color(0,255,0,1);
		graph.bars[cmp + 1] = temp;
		updateCanvas();
		// console.log("end for");
		await sleep(displayDelay);
		temp.color = color(0,255,0,0.5);
		// temp.color = tempColor;
		// console.log("setting timeout");
	}
	finished();
}