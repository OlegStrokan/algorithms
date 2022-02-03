// Binary search

const binarySearch = (arr, element) => {
    let first = 0
    let last = arr.length - 1
    let positions = -1
    let found = false
    let middle

        while (found === false && first <= last) {
            middle = Math.floor((first + last) / 2)
            if (arr[middle] === element) {
                found = true
                positions = middle
            } else if (arr[middle] > element) {
                last = middle + 1
            } else {
                first = middle - 1
            }
        }
        return positions
}

console.log(binarySearch([1,2,3],1))
