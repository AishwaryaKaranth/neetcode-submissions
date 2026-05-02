public class Solution {
    //THIS PROBLEM AIN'T INTUITIVE :/ WATCH THE VIDEO FOR A REFRESHER
    public int MinEatingSpeed(int[] piles, int h) {
        int left=1, right=piles.Max();
        //range is (0, max value of piles array)
        //perform binary search on this array
        //max value could be the answer, worst case scenario.

        while(left<right){
            int mid = left+(right-left)/2;

            int hours=0;
            foreach(var pile in piles){
                //ceiling division
                hours+= (pile+mid-1)/mid;
            }

            if(hours<=h){
                //within threshold but go slower;
                right=mid;
            }
            else{
                left=mid+1;
            }
            
        }
        return left;
    }
}
