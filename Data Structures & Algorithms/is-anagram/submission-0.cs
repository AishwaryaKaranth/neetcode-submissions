public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length ){
            return false;
        }

        var sCount = new int[26];

        for(int i=0;i<s.Length;i++){
            sCount[s[i]-'a']++;
            sCount[t[i]-'a']--;
        }
        
        return sCount.All(_ => _ == 0);
    }
}
