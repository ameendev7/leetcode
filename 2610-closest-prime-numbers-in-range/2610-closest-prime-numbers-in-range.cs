
    
        public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        int nRoot = (int)Math.Sqrt(right);
        bool[] IsNotPrime = new bool[right + 1];

        for (int i = 2; i <= nRoot; i++) {
            for (int j = i * 2; j <= right; j += i) {
                IsNotPrime[j] = true;
            }
        }

        int prev = 2000000;
        int[] res = { 2000000, 4000000 };

        for (int i = right; i >= left; i--) {
            if (!IsNotPrime[i] && i > 1) {
                if ((prev - i) < (res[1] - res[0])) {
                    res[1] = prev;
                    res[0] = i;
                } else if ((prev - i) == (res[1] - res[0])) {
                    res[1] = prev;
                    res[0] = i;
                }
                prev = i;
            }
        }

        if (res[0] > 1000000 || res[1] > 1000000) {
            return new int[] { -1, -1 };
        }

        return res;
    }
}
    