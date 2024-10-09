var findMedianSortedArrays = function(nums1, nums2) {
    a=nums1.concat(nums2)
    a.sort((a,b)=>a-b)
    if(a%2==1)
    {
        return a[a.length/2]
    }
    else{
        return (a[a.length/2]+a[(a.length+1)/2])/2
    }
};
console.log(findMedianSortedArrays([1,3],[2]));
