public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var ret = new List<bool>();
        var max = candies.Max();
        for(int i = 0;i < candies.Length;i++){
            var val = (candies[i] + extraCandies >= max) ? true : false;
            ret.Add(val);
        }
        return ret;
    }
}