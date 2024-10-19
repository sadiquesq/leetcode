var destCity = function(paths) {
    a=paths[0].length
    words=paths.join(",").split(",")
    y=[...new Set(words)]
    for(i=0;i<y.length;i++)
    {
        count=0
        for(j=0;j<words.length;j++)
        {
            if(y[i]==words[j])
            {
                count++
            }
        }

        if(count==1 && ((words.indexOf(y[i])+1)%a)==0)
        {
            return y[i]
        }
    }

};
console.log(destCity([["London","New York"],["New York","Lima"],["Lima","Sao Paulo"]]));
