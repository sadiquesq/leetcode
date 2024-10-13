var minFallingPathSum = function(grid) {
    result=0
    b=-1
    for(i=0;i<grid.length;i++)
    {
    a=Math.min(...grid[i])
    x=grid[i].indexOf(a)
    if(x==b)
    {
        s=[...grid[i]].sort((a,b)=>a-b)
        a=s[1]
        x=grid[i].indexOf(a)
    }
    b=x
    result +=a
    }
    return result
};
console.log(minFallingPathSum([[-37,51,-36,34,-22],[82,4,30,14,38],[-68,-52,-92,65,-85],[-49,-3,-77,8,-19],[-60,-71,-21,-62,-73]]));
