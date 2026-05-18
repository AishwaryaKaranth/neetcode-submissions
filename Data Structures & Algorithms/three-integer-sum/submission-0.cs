public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        //nums[i]+nums[j]= -nums[k]
        var result = new List<List<int>>();
        Array.Sort(nums);

        for(int i=0;i<nums.Length;i++){
            //if the first num is positive, no way the sum will add up to zero
            if(nums[i]>0){
                break;
            }
            //avoid duplicates
            if(i>0 && nums[i]==nums[i-1]){
                continue;
            }

            int l=i+1;
            int r=nums.Length-1;

            while(l<r){
                //3 sum for nums[i]
                var sum = nums[i] + nums[l]+nums[r];
                if(sum>0){
                    r--;
                }
                else if(sum<0){
                    l++;
                }
                else{
                    result.Add(new List<int>{nums[i], nums[l], nums[r]});
                    l++;
                    r--;
                    //avoid duplicates
                    while(l<r && nums[l]==nums[l-1]){
                        l++;
                    }
                }
            }

        }

        return result;
    }
}
