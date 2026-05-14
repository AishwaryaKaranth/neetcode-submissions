public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        var sTable = new Dictionary<char, int>();
        foreach(var c in s){
            sTable[c] = sTable.GetValueOrDefault(c) + 1;
        }

        foreach(var c in t){
            if(!sTable.ContainsKey(c) || sTable[c] == 0){
                return false;
            }
            sTable[c]--;
        }

        return true;
    }
}
