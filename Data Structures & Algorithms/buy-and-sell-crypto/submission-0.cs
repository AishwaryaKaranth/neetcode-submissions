public class Solution {
    public int MaxProfit(int[] prices) {
        //track the min so far and then calculate the max profit from there
        int minSoFar = prices[0];
        int maxProfit =0;
        foreach(int price in prices){
            maxProfit = Math.Max(maxProfit, price-minSoFar);
            minSoFar = Math.Min(minSoFar, price);
        }

        return maxProfit;

    }
}
