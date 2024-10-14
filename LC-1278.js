var palindromePartition = function(s, k) {
    
    count=0
    n=0
    for(i=0;i<s.length;i++)
    {
       a=s.slice(i,k+i)
       if(i%k==0)
       {
        b=a.split("").reverse().join("")
        if(a==b) count++
       }
    }
    return count
};
console.log(palindromePartition("aabbc",3));
