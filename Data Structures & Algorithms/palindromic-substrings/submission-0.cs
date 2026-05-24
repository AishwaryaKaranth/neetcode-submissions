public class Solution {
    public int CountSubstrings(string s) {
        //key insight: expland around the center
        //consider every character as center because you dont know which character is center in advance

        int count=0;
        for(int i=0;i<s.Length;i++){
            count+=CountPalindromes(s, i,i);//even length
            count+=CountPalindromes(s,i,i+1); //odd length
        }

        return count;
    }

    private int CountPalindromes(string s, int left, int right){
        int count=0;

        while(left>=0 && right<s.Length && s[left]==s[right]){
            left--;
            right++;
            count++;
        }

        return count;
    }
}
