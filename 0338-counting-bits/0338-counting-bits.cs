public class Solution {
    public int[] CountBits(int n){
       return Enumerable.Range(0,n+1).Select(x=>BitOperations.PopCount((uint)x)).ToArray();
    }
  
        
    }
