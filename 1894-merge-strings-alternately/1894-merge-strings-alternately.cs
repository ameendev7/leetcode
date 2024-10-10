public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder str= new StringBuilder();
        int i=0,j=0;
        while(i<word1.Length || j<word2.Length)
        {
            if(i<word1.Length)
            {
                str.Append(word1[i]);
                i++;
            }
            if(j<word2.Length)
            {
                str.Append(word2[j]);
                j++;
            }
        }
        return str.ToString();
    }
}
