public class Solution {
    public int NumDecodings(string s) {
        //each character can either be derived from a single digit or two digits
        //similar to climbing stairs problem dp[i-1] + dp[i-2]
        //pitfall: not accounting for the '0'
        //can decode empty string in 1 way -> base case

        var dp = new int[s.Length+1];
        dp[0]=1;
        dp[1] = s[0] == '0' ?0:1;
    

        for(int i=2;i<=s.Length;i++){
            //single digit if s[i-1] is not zero
            if(s[i-1]!='0'){
                dp[i]+=dp[i-1];
            }

            //grab the last two chars, if >=10 && <26 add
            int twoDigits = int.Parse(s.Substring(i-2,2));
            if(twoDigits >=10 && twoDigits <= 26){
                dp[i]+=dp[i-2];
            }
            
        }

        return dp[^1];
    }
}
