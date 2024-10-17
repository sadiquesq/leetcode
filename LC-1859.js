var sortSentence = function(s) {
    arr=[]
    words=s.split(" ")
    x=""
    for(i=0;i<words.length;i++)
    {
        a=words[i]
        x+=(a[words[i].length-1])
    }
    for(i=1;i<=words.length;i++)
    {
        b=x.indexOf(i)
        arr.push(words[b].slice(0,words[b].length-1))
        
    }
    return arr.join(" ")
};
console.log(sortSentence("is2 sentence4 This1 a3"));
