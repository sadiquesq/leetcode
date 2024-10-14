var differenceOfSum = function(nums) {
    a=nums.reduce((total,value)=>{
        return total += value;
    })
    b=0
    x=nums.join("").split("")
    for(i=0;i<x.length;i++)
    {
        b+=Number(x[i])
    }
    return Math.abs(a-b)
};
console.log(differenceOfSum([1,15,6,3]));
