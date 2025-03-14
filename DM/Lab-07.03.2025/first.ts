const test = [
	[0, 1, 0, 0, 3],
	[0, 0, 8, 7, 1],
	[0, 0, 0, 1, -5],
	[0, 0, 2, 0, 0],
	[0, 0, 0, 4, 0],
];

const FordBellmanAlgorithm = (matrix: number[][]) => {
    const lambdaArray:number[] = new Array(matrix.length).fill(0);
	for (let k = 0; k < matrix.length - 1; k++) {
		for (let i = 0; i < matrix.length; i++) {
            
            // let tempLambda = lambdaArray[k] + matrix[i][j];
        }
	}
};
