var isPalindrome = function(x) {
    
    a=x.toString()
 num=a.split("").reverse().join("")
 result=(x==num) ?  true :  false; 
 return result;
};