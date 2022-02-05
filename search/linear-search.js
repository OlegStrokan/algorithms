// Linear search

const linearSearch = (arr, item) => {
    let steps = 0


    for (let i = 0; i < arr.length; i++) {
        steps++
        if (arr[i] === item) {
            return true
        }
    }
}


console.log(linearSearch([1,2,3], 9))
