var palindromePartition = function(s, k) {
    
    x=Math.ceil(s.length/k)
    console.log(s.slice(0,3))
    for(i=0;i<x;i++)
    {
       a=s.slice(i,k+i)
       console.log(a);
       
    }

};
console.log(palindromePartition("aabbc",2));
