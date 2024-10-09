var minAddToMakeValid = function(s) {
    opening=0;
    closing=0;
    for(i=0;i<s.length;i++)
    {
        if(s[i]=="(")
        {
            opening++
        }
        else 
            {
                if(opening>0)
                {
                    opening--
                }
                else
                {
                    closing++
                }
            }
    }
    return opening + closing
    
};
console.log(minAddToMakeValid("()))"));
