var restoreString = function(s, indices) {
    arr=[]
    for(i=0;i<indices.length;i++)
    {
        arr[indices[i]]=s[i]
    }
    return arr.join("")
};