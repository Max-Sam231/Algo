const test1 = [
	[0, 1, 0, 0, 0],
	[1, 0, 1, 0, 0],
	[0, 1, 0, 1, 0],
	[0, 0, 1, 0, 0],
	[0, 0, 0, 0, 0],
];
const test2 = [
	[0, 1, 0, 0, 1],
	[1, 0, 0, 0, 0],
	[0, 0, 0, 1, 0],
	[0, 0, 1, 0, 0],
	[1, 0, 0, 0, 0],
];
const test3 = [
	[0, 0, 0, 0, 0],
	[0, 0, 0, 0, 0],
	[0, 0, 0, 0, 0],
	[0, 0, 0, 0, 0],
	[0, 0, 0, 0, 0],
];
const test4 = [
	[0, 0, 0, 1, 1],
	[0, 0, 0, 1, 0],
	[0, 0, 0, 0, 1],
	[1, 1, 0, 0, 0],
	[1, 0, 1, 0, 0],
];
const test5 = [
	[0, 1, 0, 1, 0, 0, 0],
	[1, 0, 1, 0, 0, 0, 0],
	[0, 1, 0, 1, 0, 0, 0],
	[1, 0, 1, 0, 0, 0, 0],
	[0, 0, 0, 0, 0, 1, 1],
	[0, 0, 0, 0, 1, 0, 1],
	[0, 0, 0, 0, 1, 1, 0],
];

const test6 = [
	[0, 1, 0, 0, 0],
	[1, 0, 1, 0, 0],
	[0, 1, 0, 1, 0],
	[0, 0, 1, 0, 1],
	[0, 0, 0, 1, 0],
];

const test7 = [
	[0, 1, 0, 0, 0],
	[1, 0, 1, 0, 0],
	[0, 1, 0, 1, 0],
	[0, 0, 1, 0, 1],
	[0, 0, 0, 1, 0],
];
const test8 = [
	[0, 1, 0, 0, 0, 0],
	[1, 0, 0, 0, 0, 0],
	[0, 0, 0, 1, 0, 0],
	[0, 0, 1, 0, 0, 0],
	[0, 0, 0, 0, 0, 1],
	[0, 0, 0, 0, 1, 0],
];

type Vertex = {
	name: number;
	component: number;
	connect: number[];
};

function Algorithm2(matrix: number[][]) {
	const origArray = new Array<number>();
	const conArray: Vertex[] = [];

	for (let i = 0; i < matrix.length; i++) {
		const row = matrix[i];
		origArray.push(i);
		conArray.push({name: i + 1, component: 0, connect: []});
		for (let j = 0; j < row.length; j++) {
			const element = matrix[i][j];
			if (element === 1) {
				conArray[i].connect.push(j + 1);
			}
		}
	}
	console.log(conArray);

	let countCompanent: number = 1;
	for (let i = 0; i < matrix.length; i++) {
		const vertex = conArray[i];
		if (vertex.name === 1) {
			vertex.component = countCompanent;
		} else if (conArray[i - 1].connect.indexOf(vertex.name) !== -1) {
			vertex.component = conArray[i - 1].component;
		} else if (
			vertex.connect.length !== 0 &&
			conArray[vertex.connect[0] - 1].component !== 0
		) {
			vertex.component = conArray[vertex.connect[0] - 1].component;
		} else {
			countCompanent++;
			vertex.component = countCompanent;
		}
	}
	// console.log(conArray);
	for (let i = 0; i < matrix.length; i++) {
		if (
			conArray[i].connect.length !== 0 &&
			conArray[i].component !== conArray[conArray[i].connect[0] - 1].component
		) {
			conArray[i].component = conArray[conArray[i].connect[0] - 1].component;
		}
	}
	// console.log(conArray);
	console.log(
		"Количество компонент-связности " + Math.max(...conArray.map((i) => i.component)),
	);
}

Algorithm2(test1);
Algorithm2(test2);
Algorithm2(test3);
Algorithm2(test4);
Algorithm2(test5);
Algorithm2(test6);
Algorithm2(test7);
Algorithm2(test8);
