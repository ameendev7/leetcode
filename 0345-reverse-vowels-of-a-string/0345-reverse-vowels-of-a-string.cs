public class Solution {
    public string ReverseVowels(string s) {
        char[] word = s.ToCharArray();
        int start = 0;
        int end = s.Length - 1;
        string vowels = "aeiouAEIOU";
        
        while (start < end) {
            // Move start pointer until it points to a vowel
            while (start < end && vowels.IndexOf(word[start]) == -1) {
                start++;
            }
            
            // Move end pointer until it points to a vowel
            while (start < end && vowels.IndexOf(word[end]) == -1) {
                end--;
            }
            
            // Swap the vowels
            char temp = word[start];
            word[start] = word[end];
            word[end] = temp;
            
            // Move the pointers towards each other
            start++;
            end--;
        }
        
        return new string(word);
    }
}
