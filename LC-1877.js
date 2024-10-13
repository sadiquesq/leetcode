var minPairSum = function(nums) {
    arr=[]
    nums.sort((a,b)=>a-b)
    for(i=0;i<nums.length/2;i++)
    {
        a=nums[i]+nums[nums.length-1-i]
        arr.push(a)
    }
    return Math.max(...arr)
    
};
console.log(minPairSum([3,5,2,3]));
