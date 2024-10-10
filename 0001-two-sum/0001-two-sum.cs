public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> dct = new();

        for (int i = 0; i < nums.Length; i++){ 

            int lookingFor = target - nums[i]; 
            if (dct.ContainsKey(lookingFor)){
                return new int[] {i, dct[lookingFor]}; 
            }
            dct[nums[i]] = i;
        }
        return new int[0];        
    }
}