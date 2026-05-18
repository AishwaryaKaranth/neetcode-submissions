public class Solution {
    public int MaxArea(int[] heights) {
        //height = [1,7,2,5,4,7,3,6]
        //area = height * width
        //two pointers - converging, area = (r-l)*min(height[l,height[r]])
        //area = (6-1) * min(1,6) 

        int l=0;
        int r=heights.Length-1;
        var area=0;

        while(l<r){
            var currentArea = Math.Min(heights[l], heights[r]) * (r-l);
            area = Math.Max(area, currentArea);

            if(heights[l]<=heights[r]){
                l++;
            }
            else{
                r--;
            }
        }

        return area;
    }
}
