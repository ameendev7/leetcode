public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
         int n=grid.Length;
          int[ ] nums=new int[n*n+1];
        for(int i=0;i<n;i++){
            for (int j=0;j<n;j++){
                nums[grid[i][j]]++;

            }
        }
        int[]res=new int[2];
        
        for(int i=1;i<n*n+1;i++){
           if(nums[i]==2) {
                res[0]=i;

           }
           else if(nums[i]==0){
            res[1]=i;
           }
        }
        return res;

                   
        
    }
}