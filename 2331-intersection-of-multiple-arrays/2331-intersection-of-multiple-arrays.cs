public class Solution {
    public IList<int> Intersection(int[][] nums) {
        return[..nums.Aggregate((x,y)=>x.Intersect(y).ToArray()).Order()];
    }
}