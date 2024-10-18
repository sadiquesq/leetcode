var maxProduct = function(nums) {
    n=nums.sort((a,b)=>b-a)
    return ((nums[0]-1)*(nums[1]-1))
};
console.log(maxProduct( [1,5,4,5]));
