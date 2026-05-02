public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length, cols = matrix[0].Length;
        int left =0, right =rows*cols-1;

        while(left<=right){
            int mid = left +(right-left)/2;
            int midValue = matrix[mid/cols][mid%cols];

            if(midValue == target){
                return true;
            }
            if(midValue<target){
                left=mid+1;
            }
            else{
                right=mid-1;
            }
        }

        return false;
    }
}
