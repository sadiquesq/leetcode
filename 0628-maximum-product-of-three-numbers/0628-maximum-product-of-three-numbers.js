/**
 * @param {number[]} nums
 * @return {number}
 */
var maximumProduct = function(nums) {
   nums.sort((a,b)=>a-b)
    num1=nums[0] * nums[1] * nums[nums.length-1]
    num2=nums[nums.length-1]*nums[nums.length-2]*nums[nums.length-3]
    return Math.max(num1,num2);
};