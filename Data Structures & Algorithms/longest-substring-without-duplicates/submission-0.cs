public class Solution {
    public int LengthOfLongestSubstring(string s) {
        //sliding window - l & r points to the same char, keep moving r if s[r] is not in the set

        int l=0;
        int longest=0;
        var set = new HashSet<char>();

        for(int i=0;i<s.Length;i++){
            //if the char is there in the set, remove it so you can consider a new substring
            while(set.Contains(s[i])){
                set.Remove(s[l]);
                //remove the existing char and move forward
                l++;
            }

            set.Add(s[i]);
            //current length of the substrign
            var currentLength = (i-l)+1;
            longest = Math.Max(longest, currentLength);

        }

        return longest;
    }
}
