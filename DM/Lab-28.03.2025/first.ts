const matrix = [
	[0, 0, 0],
	[0, Infinity, 0],
	[0, 0, 0],
];

const WaveAlgorithm = (start: number[], end: number[], matrix: number[][]) => {
	const pointArray = [start];
	const visited = matrix.map((row) => row.map((i) => false));
	const distance = matrix.map((row) => row.map((i) => Infinity));
	const directions = [
		[-1, 0],
		[1, 0],
		[0, -1],
		[0, 1],
	];
	visited[start[0]][start[1]] = true;
	distance[start[0]][start[1]] = 0;

	while (pointArray.length > 0) {
		const current = pointArray.shift()!;
		const [x, y] = current;

		if (x === end[0] && y === end[1]) {
			return distance[x][y];
		}

		for (const [dx, dy] of directions) {
			const newX = x + dx;
			const newY = y + dy;
			if (
				newX >= 0 &&
				newX < matrix.length &&
				newY >= 0 &&
				newY < matrix[0].length &&
				matrix[newX][newY] !== Infinity &&
				!visited[newX][newY]
			) {
				visited[newX][newY] = true;
				distance[newX][newY] = distance[x][y] + 1;
				pointArray.push([newX, newY]);
			}
		}
	}
	return null;
};

console.log(WaveAlgorithm([0, 0], [2, 2], matrix));
