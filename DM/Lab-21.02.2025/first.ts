import {AlgorithmConnect} from "../Lab-07.02.2025/second.ts";
import {AlgorithmKruscal, Edge} from "../Lab-14.02.2025/second.ts";

const test1 = [
	[0, 2, 3],
	[2, 0, 1],
	[3, 1, 0],
];

const test2 = [
	[0, 1, 0],
	[1, 0, 2],
	[0, 2, 0],
];

const test3 = [
	[0, 1, 0, 0],
	[1, 0, 2, 0],
	[0, 2, 0, 3],
	[0, 0, 3, 0],
];
const test4 = [
	[0, 2, 3],
	[2, 0, 1],
	[3, 1, 0],
];
const test5 = [
	[0, 5],
	[5, 0],
];
const test6 = [
	[0, 2, 3, 0],
	[2, 0, 1, 4],
	[3, 1, 0, 5],
	[0, 4, 5, 0],
];
const test7 = [
	[0, 2, 3, 0],
	[2, 0, 1, 0],
	[3, 1, 0, 4],
	[0, 0, 4, 0],
];

const AlgorithmBridge = (matrix: number[][]) => {
	const BridgeArray: Edge[] = [];
	const originCountCompanent: number = Math.max(
		...AlgorithmConnect(matrix).map((i) => i.component),
	);
	// console.log(originCountCompanent);

	const mstEdgeArray: Edge[] = AlgorithmKruscal(matrix);
	// console.log(mstEdgeArray);
	
	for (let i = 0; i < mstEdgeArray.length; i++) {
		const element = mstEdgeArray[i];
		matrix[element.start][element.end] = 0;
		matrix[element.end][element.start] = 0;
		let tempCountCompanent = Math.max(...AlgorithmConnect(matrix).map((i) => i.component));
		// console.log(tempCountCompanent);
		
		if (originCountCompanent < tempCountCompanent) {
			BridgeArray.push(element);
			console.log(`Мост ${element.start} - ${element.end}`);
		}
		matrix[element.start][element.end] = element.weight;
		matrix[element.end][element.start] = element.weight;
	}
	if (BridgeArray.length == 0) {
		console.log("нет мостов");
	}
};
// AlgorithmBridge(test1);
AlgorithmBridge(test2);
// AlgorithmBridge(test3);
// AlgorithmBridge(test4);
// AlgorithmBridge(test5);
// AlgorithmBridge(test6);
// AlgorithmBridge(test7);
