public class Solution {
    public int CountMaxOrSubsets(int[] nums) {
        
        var len = (int) Math.Pow(2, nums.Length);
        var list = new List<int>(len);
        
        void Solve(int bitwiseOr = 0, int ptr = 0) {
            
            if (ptr == nums.Length) {
                list.Add(bitwiseOr);
                return;
            } 

            // pick
            Solve(bitwiseOr | nums[ptr], ptr + 1);

            // skip
            Solve(bitwiseOr, ptr + 1);
        }

        Solve();

        var max = list.Max();
        return list.Count(x => x == max);
    }
}