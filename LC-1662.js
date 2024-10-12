var arrayStringsAreEqual = function(word1, word2) {
    s1=word1.join("")
    s2=word2.join("")
    return s1==s2

};
console.log(arrayStringsAreEqual(["ab", "c"],["a","bc"]));
