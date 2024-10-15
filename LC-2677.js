var chunk = function(arr, size) {
    if(arr.length==0) return arr
    main=[]
    if(arr.length<=size)
    {
        return [arr]
    };
    x=0
    y=size
    for(i=0;i<arr.length/size;i++)
    {
        array=[]
        for(j=x;j<y;j++)
        {
            if(j<arr.length){
                array.push(arr[j])
            }
        }
        x+=size
        y+=size
        main.push(array)
    }
    return main
};
console.log(chunk( [1,9,6,3,2],3));
