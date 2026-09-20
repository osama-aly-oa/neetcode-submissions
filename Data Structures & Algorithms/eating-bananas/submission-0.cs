public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1, r = piles.Max(), res = r;

        while(l <= r) {
            int k = l + (r -l) / 2;

            long totalTime = 0;
            foreach(int pile in piles) {
            totalTime += (pile + k - 1) / k;         
            }

            if(totalTime <= h){
                res = k;
                r = k -1;
            } else {
                l = k + 1;
            }
        }
        return res;
    }
}
