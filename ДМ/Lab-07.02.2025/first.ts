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

function Algorithm1(matrix: number[][]) {
	const origArray = new Array<number>();
	const conArray: number[][] = [];

	for (let i = 0; i < matrix.length; i++) {
		origArray.push(i);
		conArray.push([]);
	}

	let row = 0;
	let indexCompanent = 0;

	while (origArray.length != 0) {
		for (let i = 0; i < matrix.length; i++) {
			const element = matrix[row][i];
			const isInArrayElem = conArray[indexCompanent].indexOf(i);
			const isInArrayRow = conArray[indexCompanent].indexOf(row);
			if (element == 1) {
				if (conArray[indexCompanent].length === 0) {
					conArray[indexCompanent].push(row);
					conArray[indexCompanent].push(i);
					const indexOrig = origArray.indexOf(i);
					origArray.splice(indexOrig, 1);
				} else if (isInArrayElem !== -1 || isInArrayRow !== -1) {
					conArray[indexCompanent].push(row);
					conArray[indexCompanent].push(i);
				} else {
					indexCompanent++;
					conArray[indexCompanent].push(row);
					conArray[indexCompanent].push(i);
				}
			}
		}
		if (matrix[origArray[0]].every((element) => element === 0)) {
			conArray.push([row]);
			// console.log(row);
		}
		origArray.shift();
		row++;
	}
	let res: number = 0;
	// console.log(conArray);
	conArray.map((i) => {
		if (i.length !== 0) {
			res++;
		}
	});
	console.log('Количество компонент-связности ' + res);
}

Algorithm1(test1);
Algorithm1(test2);
Algorithm1(test3);
Algorithm1(test4);
Algorithm1(test5);
Algorithm1(test6);
Algorithm1(test7);
Algorithm1(test8);

