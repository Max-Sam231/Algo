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

type Edge = {
	start: number;
	end: number;
	weight: number;
};

function Algorithm2(matrix: number[][]) {
	const edgeArray: Edge[] = [];
	const resArray: number[] = [];

	for (let i = 0; i < matrix.length; i++) {
		for (let j = 0; j < matrix.length; j++) {
			const element = matrix[i][j];
			if (element !== 0) {
				edgeArray.push({start: i, end: j, weight: element});
			}
		}
	}
	edgeArray.sort((a, b) => a.weight - b.weight);
	const conArray = new Array(matrix.length).fill(0).map((_, i) => i);

	const Find = (vertex: number): number => {
		while (conArray[vertex] !== vertex) {
			vertex = conArray[vertex];
		}
		return vertex;
	};

	for (const edge of edgeArray) {
		const start = Find(edge.start);
		const end = Find(edge.end);

		if (start !== end) {
			resArray.push(edge.weight);
			conArray[end] = start;
		}
	}
	// console.log(resArray);
	console.log(resArray.reduce((acc, cur) => acc + cur, 0));
}
Algorithm2(test1);
Algorithm2(test2);
Algorithm2(test3);
Algorithm2(test4);
Algorithm2(test5);
Algorithm2(test6);
Algorithm2(test7);
Algorithm2(test8);
