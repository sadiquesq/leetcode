var countDigits = function(num) {
    split=num.toString().split("")
    count=0
    for(i=0;i<split.length;i++)
    {
        if(num%Number(split[i])==0)
        {
            count++
        }
    }
    return count
};
console.log(countDigits(121));
