public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) {
            return false;
        }

        int[] s1Count = new int[26];
        int[] s2Count = new int[26];

        for (int i = 0; i < s1.Length; i++) {
            s1Count[s1[i] - 'a']++;
            s2Count[s2[i] - 'a']++;
        }

        int matches = 0;
        for (int i = 0; i < 26; i++) {
            if (s1Count[i] == s2Count[i]) {
                matches++;
            }
        }

        int l = 0;
        for (int r = s1.Length; r < s2.Length; r++) {
            if (matches == 26) {
                return true;
            }

            int indexRight = s2[r] - 'a';
            s2Count[indexRight]++;
            if (s1Count[indexRight] == s2Count[indexRight]) {
                matches++;
            } else if (s1Count[indexRight] + 1 == s2Count[indexRight]) {
                matches--;
            }

            int indexLeft = s2[l] - 'a';
            s2Count[indexLeft]--;
            if (s1Count[indexLeft] == s2Count[indexLeft]) {
                matches++;
            } else if (s1Count[indexLeft] - 1 == s2Count[indexLeft]) {
                matches--;
            }

            l++;
        }

        return matches == 26;
    }
}