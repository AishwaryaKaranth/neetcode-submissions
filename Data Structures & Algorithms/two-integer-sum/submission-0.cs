public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        var result = new int[2];

        for(int i=0;i<nums.Length;i++){
            var diff = target-nums[i];

            if(dict.TryGetValue(diff, out var j)){
                result[0] =j;
                result[1] =i;
                return result;
            }

            dict[nums[i]]=i;
        }

        return result;
    }
}
