public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> countS = new Dictionary<char, int>();
        Dictionary<char, int> countT = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            countS[s[i]] = countS.GetValueOrDefault(s[i], 0) + 1;
            countT[t[i]] = countT.GetValueOrDefault(t[i], 0) + 1;
         }

        if (countS.Count != countT.Count) {
            return false;
            }

            foreach (KeyValuePair<char, int> pair in countS) {
            char letter = pair.Key;
            int countInS = pair.Value;

            if (!countT.ContainsKey(letter) || countT[letter] != countInS) {
                return false; 
            }
        }

            return true;
    }
}            