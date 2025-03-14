const test = [
	[0, 3, Infinity, 7],
	[8, 0, 2, Infinity],
	[5, Infinity, 0, 1],
	[2, Infinity, Infinity, 0],
];
const FloidAlgorithm = (matrix: number[][]) => {
	const resMatrix: number[][] = new Array(matrix.length)
		.fill([])
		.map(() => new Array(matrix.length).fill(Infinity));
	for (let i = 0; i < resMatrix.length; i++) {
		for (let j = 0; j < resMatrix.length; j++) {
			resMatrix[i][i] = 0;
			if (matrix[i][j] !== 0) {
				resMatrix[i][j] = matrix[i][j];
			}
		}
	}
	for (let k = 0; k < matrix.length; k++) {
		for (let i = 0; i < matrix.length; i++) {
			for (let j = 0; j < matrix.length; j++) {
				if (resMatrix[i][k] + resMatrix[k][j] < resMatrix[i][j]) {
					resMatrix[i][j] = resMatrix[i][k] + resMatrix[k][j];
				}
			}
		}
	}
	resMatrix.map((i, ind) => console.log(`из вершины ${ind} расстояния до остальных ${i}`));
};
FloidAlgorithm(test);
