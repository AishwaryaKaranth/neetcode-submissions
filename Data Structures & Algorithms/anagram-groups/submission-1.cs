public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach(var s in strs){
            var count = new int[26];

            foreach(var c in s){
                //Console.WriteLine($"{c}, {count[c-'a']}");
                count[c-'a']++;
            }

            var key = string.Join("#", count);
            Console.WriteLine(key);
            if(!dict.ContainsKey(key)){
                dict[key] = new List<string>();
            }

            dict[key].Add(s);
        }

        return dict.Values.ToList();
    }
}
