using System;
using System.Text;
public class Solution {
    public string ReverseVowels(string s) {
        //char[] temp = s.ToCharArray();
        char temp = new char();
        char[] result = s.ToCharArray();
        char[] vowels = {'a','e','i','o','u', 'A', 'E', 'I', 'O', 'U'};
        int leftindex = 0;
        int rightindex = s.Length - 1;
        bool leftflag = true;
        bool rightflag = true;
        while (leftindex < rightindex) {
            foreach (char x in vowels) {
                if(leftflag)
                    if(x == result[leftindex])
                        leftflag = false;
                if(rightflag)
                    if(x == result[rightindex])
                        rightflag = false;
            }
            if (!leftflag && !rightflag) {
                //result[leftindex] = temp[rightindex];
                //result[rightindex] = temp[leftindex];
                temp = result[leftindex];
                result[leftindex] = result[rightindex];
                result[rightindex] = temp;
                leftflag = true;
                rightflag = true;
            }
            if(rightflag)
                rightindex--;
            if(leftflag)
                leftindex++;
        }
        return new String(result);
        //string also TLE problem
        /*string temp = s;
        string temp1 = "";
        string temp2 = "";
        string temp3 = "";
        char[] vowels = {'a','e','i','o','u', 'A', 'E', 'I', 'O', 'U'};
        int leftindex = 0;
        int rightindex = s.Length - 1;
        bool leftflag = true;
        bool rightflag = true;
        while (leftindex < rightindex) {
            foreach (char x in vowels) {
                if(leftflag)
                    if(x.ToString() == temp.Substring(leftindex,1))
                        leftflag = false;
                if(rightflag)
                    if(x.ToString() == temp.Substring(rightindex,1))
                        rightflag = false;
            }
            if (!leftflag && !rightflag) {
                temp1 = "";
                temp2 = "";
                temp3 = "";
                if(leftindex != 0)
                    temp1 = temp.Substring(0, leftindex);
                if(leftindex + 1 != rightindex)
                    temp2 = temp.Substring(leftindex + 1, rightindex - leftindex - 1);
                if(rightindex != s.Length - 1)
                    temp3 = temp.Substring(rightindex + 1);
                temp = temp1 + temp.Substring(rightindex, 1) + temp2 + temp.Substring(leftindex, 1) + temp3;
                leftflag = true;
                rightflag = true;
            }
            if(rightflag)
                rightindex--;
            if(leftflag)
                leftindex++;
        }
        return temp;*/
        //StringBuilder version----TLE
        /*StringBuilder sb = new StringBuilder(s.Length);
        StringBuilder sbtemp = new StringBuilder();
        StringBuilder sb1 = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        StringBuilder sb3 = new StringBuilder();
        sb.Append(s);
        sbtemp.Append(s);
        char[] vowels = {'a','e','i','o','u', 'A', 'E', 'I', 'O', 'U'};
        int leftindex = 0;
        int rightindex = s.Length - 1;
        bool leftflag = true;
        bool rightflag = true;
        while (leftindex < rightindex) {
            foreach (char x in vowels) {
                if(leftflag)
                    if(x.ToString() == s.Substring(leftindex,1))
                        leftflag = false;
                if(rightflag)
                    if(x.ToString() == s.Substring(rightindex,1))
                        rightflag = false;
            }
            if (!leftflag && !rightflag) {
                sb = new StringBuilder(s.Length);
                sb1 = new StringBuilder();
                sb1.Append(sbtemp.ToString().Substring(0, leftindex));
                sb2 = new StringBuilder();
                sb2.Append(sbtemp.ToString().Substring(leftindex + 1, rightindex - leftindex - 1));
                sb3 = new StringBuilder();
                sb3.Append(sbtemp.ToString().Substring(rightindex + 1));
                if(leftindex == 0)
                    sb1 = new StringBuilder();
                if(leftindex + 1 == rightindex)
                    sb2 = new StringBuilder();
                if(rightindex == s.Length - 1)
                    sb3 = new StringBuilder();
                sb.Append(sb1.ToString() + sbtemp.ToString().Substring(rightindex, 1) + sb2.ToString() + sbtemp.ToString().Substring(leftindex, 1) + sb3.ToString());
                leftflag = true;
                rightflag = true;
                sbtemp = new StringBuilder();
                sbtemp.Append(sb.ToString());
            }
            if(rightflag)
                rightindex--;
            if(leftflag)
                leftindex++;
        }
        return sb.ToString();*/
    }
}
