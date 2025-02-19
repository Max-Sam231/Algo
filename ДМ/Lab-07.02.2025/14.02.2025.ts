const test1 = [
	[0, 2, 0, 0, 0],
	[2, 0, 6, 0, 0],
	[0, 6, 0, 10, 0],
	[0, 0, 10, 0, 5],
	[0, 0, 0, 5, 0],
];

function Algorithm1(matrix: number[][]) {
	const conArray = new Map<number, number[][]>();
	const resArray: number[] = [];
	const weightArray: number[] = [];

	for (let i: number = 0; i < matrix.length; i++) {
		conArray.set(i + 1, []);
		for (let j = 0; j < matrix.length; j++) {
			const element = matrix[i][j];
			if (element !== 0) {
				conArray.get(i + 1)?.push([j + 1, element]);
			}
		}
	}
	console.log(conArray);

	for (const [key, value] of conArray) {
		value.sort((a, b) => a[1] - b[1]);
		if (resArray.indexOf(key) === -1) {
			resArray.push(key);
		}
		const minArr: number[] = [];
		let minElem: number = 0;
		for (let i = 0; i < value.length; i++) {
			const element = value[i];
			if (resArray.indexOf(element[0]) === -1) {
				minArr.push(value[i][1]);
				resArray.push(element[0]);
				minElem = Math.min(...minArr);
			}
		}
		if (minElem !== 0) {
			weightArray.push(minElem);
		}
	}
	console.log(resArray);
	console.log(weightArray);
	console.log(weightArray.reduce((acc, cur)=> acc+cur,0));
}
Algorithm1(test1);

// 	const origArray = new Array<number>();
// 	const conArray: Vertex[] = [];
// 	const weightArray: number[] = [];
// 	const vertexArray: number[] = [];

// 	for (let i = 0; i < matrix.length; i++) {
// 		const row = matrix[i];
// 		origArray.push(i);
// 		conArray.push({name: i + 1, weight: [], connect: []});
// 		for (let j = 0; j < row.length; j++) {
// 			const element = matrix[i][j];
// 			if (element !== 0) {
// 				conArray[i].connect.push(j + 1);
// 				conArray[i].weight.push(element);
// 			}
// 		}
// 	}
// 	console.log(conArray);
// 	let resWeight: number = 0;
// 	for (let i = 0; i < conArray.length; i++) {
// 		if (vertexArray.indexOf(conArray[i].name) === -1) {
// 			vertexArray.push(conArray[i].name);
// 		}
// 		let weightMin: number = 0;
// 		for (let j = 0; j < conArray.length; j++) {
// 			const element: number = conArray[i].connect[j];
// 			// if (vertexArray.indexOf(element) === -1) {}

// 		}
// 		// if (vertexArray.indexOf(element) === -1) {
// 		// vertexArray.push(element);
// 		// weightArray.push(weightMin);
// 		// }
// 	}
// 	console.log(vertexArray);
