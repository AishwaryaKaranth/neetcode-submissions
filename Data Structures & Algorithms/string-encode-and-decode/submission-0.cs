public class Solution {
    //Initial approach was a flop. We have to use the length of the string followed by a delimiter while encoding. 
    //Why delimiter and why not just the length? because what happens if the length of the word is more than 9?? so use a delimiter after the length
    public string Encode(IList<string> strs) {
        var result = "";
        foreach(var s in strs){
            result += (s.Length + "#" + s);
        }

        return result;
    }

    public List<string> Decode(string s) {
        //have two pointers i, j. j to get the delimiter and essentially the length of the string and then move i to get he next word.
        int i =0;
        var result = new List<string>();
        while(i< s.Length){
            int j=i;
            while(s[j]!='#'){
                j++;
            }
            //2#hi
            //i -> 2
            //j -> #
            int length = int.Parse(s.Substring(i, j-i));
            //j-i because to account for length greater than 9
            result.Add(s.Substring(j + 1, length));
            //move i to the next word
            i=j+1+length;
        }

        return result;
   }
}
