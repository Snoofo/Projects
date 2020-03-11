

async function sortQuick(graph, start, end){

// console.log("bars = " + graph.bars[0].h);
	if (start>=end){
		return;
	}
	var index = await partition(graph.bars, start, end);
	if (index < 0){
			console.log("index < 0");
		return;
	}
	await Promise.all([
		sortQuick(graph, start, index),
		sortQuick(graph, index+1, end)
		]);
	if (cancel){
		return;
	}
	if (start == 0 && end == graph.bars.length-1){
		finished();
	}
}

async function partition(bars, start, end){
	// console.log("bars = " + bars[0].h);
	// console.log("start = " + start);
	// console.log("end = " + end);
	var pivotIndex = parseInt(start + ((end - start)/2));
	console.log("partition start");
	console.log("pivotIndex = " + pivotIndex);
	var pivotValue = bars[pivotIndex].h;
	var i = start -1;
	var j = end + 1;
	var tempColor = bars[pivotIndex].color;
	bars[pivotIndex].color = color(255,0,0,1);
	updateCanvas();
	await sleep(displayDelay);
	while(true){
		if (cancel){
			console.log("cancel");
			return -1;
		}
		do {
			++i;
			// console.log("do i: " + i);
		} while (bars[i].h < pivotValue);
		do {
			--j;
			// console.log("do j: " + j);
		} while (bars[j].h > pivotValue);
		if (i >= j){
			bars[pivotIndex].color = tempColor;
			return j;
		}
		bars[i].color = color(0,255,0,0.5);
		bars[j].color = color(0,255,0,0.5);
		updateCanvas();
		await sleep(shuffleDelay);
		swapBar(graph, i, j);
		updateCanvas();
		await sleep(shuffleDelay);
		bars[i].color = tempColor;
		bars[j].color = tempColor;
	}
}