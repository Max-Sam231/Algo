const test1 = [
	[0, 6, 6, 0, 0, 4],
	[0, 0, 0, 87, 0, 0],
	[4, 0, 0, 0, 54, 56],
	[0, 5, 0, 0, 3, 0],
	[58, 3, 0, 0, 0, 0],
	[6, 0, 8, 6, 0, 0],
];

const AlgorithmDeikctra = (matrix: number[][], start: number, end: number) => {
	const visitedArray: boolean[] = new Array(matrix.length).fill(false);
	const widthArray: number[] = new Array(matrix.length).fill(Infinity);
	widthArray[start] = 0;
	for (let i = 0; i < matrix.length - 1; i++) {
		const minVertex = MinWidth(widthArray, visitedArray);
		if (minVertex === -1) {
			break;
		}
		visitedArray[minVertex] = true;
		for (let j = 0; j < matrix.length; j++) {
			if (
				visitedArray[j] === false &&
				matrix[minVertex][j] !== 0 &&
				widthArray[minVertex] !== Infinity &&
				widthArray[minVertex] + matrix[minVertex][j] < widthArray[j]
			) {
				widthArray[j] = widthArray[minVertex] + matrix[minVertex][j];
			}
		}
	}
	console.log(widthArray[end]);
	return widthArray[end];
};
const MinWidth = (width: number[], visit: boolean[]) => {
	let minWidth: number = Infinity;
	let minVertex: number = -1;
	for (let i = 0; i < width.length; i++) {
		if (visit[i] == false && width[i] <= minWidth) {
			minWidth = width[i];
			minVertex = i;
		}
	}
	return minVertex;
};
AlgorithmDeikctra(test1, 0, 2);
