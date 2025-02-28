const test1 = [
	[0, 1, 2],
	[1, 0, 3],
	[2, 3, 0],
];
const test2 = [
	[0, 2, 0, 6],
	[2, 0, 3, 8],
	[0, 3, 0, 0],
	[6, 8, 0, 0],
];
const test3 = [
	[0, 2, 0, 6, 0],
	[2, 0, 3, 8, 5],
	[0, 3, 0, 0, 7],
	[6, 8, 0, 0, 9],
	[0, 5, 7, 9, 0],
];
const test4 = [
	[0, 1, 1, 1],
	[1, 0, 1, 1],
	[1, 1, 0, 1],
	[1, 1, 1, 0],
];
const test5 = [
	[0, 4, 0, 0, 0, 2],
	[4, 0, 8, 0, 0, 3],
	[0, 8, 0, 7, 0, 1],
	[0, 0, 7, 0, 9, 0],
	[0, 0, 0, 9, 0, 5],
	[2, 3, 1, 0, 5, 0],
];
const test6 = [
	[0, 1, 2, 100],
	[1, 0, 3, 4],
	[2, 3, 0, 5],
	[100, 4, 5, 0],
];
const test7 = [
	[0, 1, 1, 0, 0],
	[1, 0, 1, 1, 0],
	[1, 1, 0, 1, 1],
	[0, 1, 1, 0, 1],
	[0, 0, 1, 1, 0],
];
const test8 = [
	[0, 7, 0, 5, 0, 0, 0],
	[7, 0, 8, 9, 7, 0, 0],
	[0, 8, 0, 0, 5, 0, 0],
	[5, 9, 0, 0, 15, 6, 0],
	[0, 7, 5, 15, 0, 8, 9],
	[0, 0, 0, 6, 8, 0, 11],
	[0, 0, 0, 0, 9, 11, 0],
];
type VerConnect = {
	vertex: number;
	weight: number;
};
function AlgorithmPrima(matrix: number[][]) {
	const conArray: VerConnect[][] = [];
	const resArray: number[] = [];
	const checkArray: boolean[] = new Array(matrix.length).fill(false);

	for (let i: number = 0; i < matrix.length; i++) {
		conArray.push([]);
		for (let j = 0; j < matrix.length; j++) {
			const element = matrix[i][j];
			if (element !== 0) {
				conArray[i].push({vertex: j, weight: element});
			}
		}
	}
	checkArray[0] = true;
	while (resArray.length < matrix.length - 1) {
		let minEdge: VerConnect | null = null;

		for (let i = 0; i < matrix.length; i++) {
			if (checkArray[i]) {
				for (let j = 0; j < conArray[i].length; j++) {
					const edge = conArray[i][j];
					if (
						!checkArray[edge.vertex] &&
						(minEdge === null || edge.weight < minEdge.weight)
					) {
						minEdge = edge;
					}
				}
			}
		}

		if (minEdge !== null) {
			resArray.push(minEdge.weight);
			checkArray[minEdge.vertex] = true;
		}
	}
	console.log(resArray.reduce((acc, cur) => acc + cur, 0));
}
AlgorithmPrima(test1);
AlgorithmPrima(test2);
AlgorithmPrima(test3);
AlgorithmPrima(test4);
AlgorithmPrima(test5);
AlgorithmPrima(test6);
AlgorithmPrima(test7);
AlgorithmPrima(test8);
