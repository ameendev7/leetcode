public class Solution {
    public int MaximumCount(int[] nums) {
          int ng=0,ps=0;
          foreach(int x in nums)
          if(x>0)
          ps++;
          else if(x<0)
          ng++;
          return Math.Max(ng,ps);
    }
}