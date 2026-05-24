public class Solution {
    public string LongestPalindrome(string s) {
        //same plaindrome substrigns. keep track of the longest stirng
        string longest = "";
        for(int i=0;i<s.Length;i++){
            var evenLongest = Check(s, i,i+1);
            longest = evenLongest.Length>longest.Length ? evenLongest: longest;

            var oddLongest = Check(s,i,i);
            longest = oddLongest.Length>longest.Length ? oddLongest: longest;
        }

        return longest;
    }

    private string Check(string s, int left, int right){
        while(left>=0 && right<s.Length && s[left]==s[right]){
            left--;
            right++;
        }

        //return the substrign left and the length
        return s.Substring(left+1, right-left-1);
    }
}
