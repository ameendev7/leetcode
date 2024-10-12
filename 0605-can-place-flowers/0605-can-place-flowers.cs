public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int len = flowerbed.Length;
        int count = 0;
        for (int i = 0; i < len && count < n; i++) {
            if (flowerbed[i] == 0) {
                bool leftEmpty = (i == 0) || (flowerbed[i - 1] == 0);
                bool rightEmpty = (i == len - 1) || (flowerbed[i + 1] == 0);

                if (leftEmpty && rightEmpty) {
                    flowerbed[i] = 1;
                    count++;
                }
            }
        }
        return count == n;
    }
}