public class Solution {
    public int[] Shuffle(int[] nums, int n) {
         int j=0;
         int [] nums2=new int [n*2];
        // int []  result= new int [8]

        for  (int i=0;i<n;i++){
            nums2[j++]=nums[i];
            nums2[j++]=nums[i+n];

        }
       return nums2;
    }
}