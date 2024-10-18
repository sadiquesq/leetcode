var separateDigits = function(nums) {
     arr=[]
     a=nums.join("").split("")
     for(i=0;i<a.length;i++)
     {
        arr.push(Number(a[i]))
     }
    return arr
};
console.log(separateDigits([13,25,83,77]));
