var leftRightDifference = function(nums) {
    arr=[]
    left=0
    rigth=0;
    x=0
    for(i=0;i<nums.length;i++)
    {
        a=nums.slice(0,i)
        b=nums.slice(i+1,nums.length)
        left=a.reduce((total,value)=>{
           return total += value
        },0)
        rigth=b.reduce((total,value)=>{
            return total += value
         },0)
         x=Math.abs(left-rigth);
         arr.push(x)
    }
    return arr
};
console.log(leftRightDifference([10,4,8,3]));
