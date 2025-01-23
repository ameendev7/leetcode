public class Solution {
    public void ReverseString(char[] s) {
        for(int left=0, right=s.Length-1; left<right;left++,right--){
           (s[left],s[right])=(s[right],s[left]);
        }
    }
}