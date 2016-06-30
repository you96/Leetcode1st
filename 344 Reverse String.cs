public class Solution {
    public string ReverseString(string s) {
        //if (string.IsNullOrEmpty(s)) {
        //    throw new ArgumentException("empty string called.");
        //}
        StringBuilder sb = new StringBuilder(s.Length);
        for (int i = s.Length - 1; i >=0; i--) {
            sb.Append(s.Substring(i,1));
        }
        return sb.ToString();
    }
}
