const test= [
    [0, -1, 4, 0, 0],
    [0, 0, 3, 2, 2],
    [0, 0, 0, 0, 0],
    [0, 1, 5, 0, 0],
    [0, 0, 0, -3, 0]
];

const FordBellmanAlgorithm = (matrix: number[][], start: number) => {
	const lambdaArray: number[] = new Array(matrix.length).fill(Infinity);
	lambdaArray[start] = 0;
	for (let k = 0; k < matrix.length - 1; k++) {
		for (let i = 0; i < matrix.length; i++) {
			for (let j = 0; j < matrix.length; j++) {
				if (
					matrix[i][j] !== 0 &&
					lambdaArray[i] !== Infinity &&
					lambdaArray[i] + matrix[i][j] < lambdaArray[j]
				) {
					lambdaArray[j] = lambdaArray[i] + matrix[i][j];
				}
			}
		}
	}

	for (let i = 0; i < matrix.length; i++) {
		for (let j = 0; j < matrix.length; j++) {
			if (
				matrix[i][j] !== 0 &&
				lambdaArray[i] !== Infinity &&
				lambdaArray[i] + matrix[i][j] < lambdaArray[j]
			) {
                console.log("Есть отрицательный цикл");
			}
		}
	}
    console.log(`от ${start} до остальных вершин ${lambdaArray}`);
};

FordBellmanAlgorithm(test,0)