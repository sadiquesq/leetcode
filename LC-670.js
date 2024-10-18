var maximumSwap = function(num) {
    a=num.toString().split("");
    b=Math.max(...a)
    x=num.toString().lastIndexOf(b)
    a[x]=a[0]
    a[0]=b
    y=""
    for(i=0;i<a.length;i++)
    {
        y+=a[i]
    }
    return Number(y

};
console.log(maximumSwap(2736));

