// Missing number

const missingNumber = (nums) => {
    const len = nums.length

    return (len * (len + 1) / 2  - nums.reduce((a,b) => { return a + b},0))
}

console.log(missingNumber([0,1,3]))
