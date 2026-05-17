public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //two pointer algorithm. converging pointer traversal 
        int left=0;
        int right=numbers.Length-1;
        var result = new int[2];

        while(left<right){
            var sum = numbers[left]+numbers[right];
            
            if(sum==target){
                result[0]=left+1;
                result[1]=right+1;
                return result;
            }

            if(sum < target){
                left++;
            }
            else{
                right--;
            }
        }

        return result;
    }
}
