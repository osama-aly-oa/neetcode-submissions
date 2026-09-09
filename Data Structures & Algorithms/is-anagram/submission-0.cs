public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) {
            return false;
        }
        
        Dictionary <char, int> sMap = new Dictionary <char, int>();
        Dictionary <char, int> tMap = new Dictionary <char, int>();


        for(int i = 0; i < s.Length; i++){
            sMap[s[i]] = sMap.GetValueOrDefault(s[i],0) + 1;
            tMap[t[i]] = tMap.GetValueOrDefault(t[i], 0) + 1;

        }
        return sMap.Count == tMap.Count && !sMap.Except(tMap).Any();

        }
    }            


        // char[] chars = s.ToCharArray();
        // Array.Sort(chars);
        // string sSorted = new string(chars);

        // char[] chars2 = t.ToCharArray();
        // Array.Sort(chars2);
        // string tSorted = new string(chars2);

        // if(sSorted == tSorted) {
        //    return true;
        // }

        // return false;   