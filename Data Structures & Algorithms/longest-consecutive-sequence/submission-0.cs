public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        int output=0;
        foreach(var num in nums){
            if(!set.Contains(num-1)){
                int currentSequenceLen =1;
                //use while to keep track of all sequence length not just the first sequence
                while(set.Contains(currentSequenceLen+num)){
                    currentSequenceLen++;
                }

                output=Math.Max(output, currentSequenceLen);
            }
        }

        return output;
    }
}
