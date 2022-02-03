// Contains duplicate

const containsDuplicate = (nums) => {
	const mySet = new Set();

	for (const num of nums) {
		if (mySet.has(num)) {
			return true
		}
		mySet.add(num)
	}
	return true
}

console.log(containsDuplicate([1, 2, 3]))
