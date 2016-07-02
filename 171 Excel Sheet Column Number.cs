public class Solution {
    public int GetValue(char x){
        
        return (Convert.ToInt32(x) - 64);//KeyCode for A equals 65
        /*int y = 0;
        switch (x){
            case 'A':
                y = 1;
                break;
            case 'B':
                y = 2;
                break;
            case 'C':
                y = 3;
                break;
            case 'D':
                y = 4;
                break;
            case 'E':
                y = 5;
                break;
            case 'F':
                y = 6;
                break;
            case 'G':
                y = 7;
                break;
            case 'H':
                y = 8;
                break;
            case 'I':
                y = 9;
                break;
            case 'J':
                y = 10;
                break;
            case 'K':
                y = 11;
                break;
            case 'L':
                y = 12;
                break;
            case 'M':
                y = 13;
                break;
            case 'N':
                y = 14;
                break;
            case 'O':
                y = 15;
                break;
            case 'P':
                y = 16;
                break;
            case 'Q':
                y = 17;
                break;
            case 'R':
                y = 18;
                break;
            case 'S':
                y = 19;
                break;
            case 'T':
                y = 20;
                break;
            case 'U':
                y = 21;
                break;
            case 'V':
                y = 22;
                break;
            case 'W':
                y = 23;
                break;
            case 'X':
                y = 24;
                break;
            case 'Y':
                y = 25;
                break;
            case 'Z':
                y = 26;
                break;
            default:
                y = 0;
                break;
        }
        return y;*/
    }
    public int TitleToNumber(string s) {
        char[] a = s.Trim().ToCharArray();
        Array.Reverse(a);
        int b = s.Trim().Length;
        int result = 0;
        int basenum = 1;
        for(int i = 0; i < b; i++) {
            basenum = 1;
            for(int j = 1; j <= i; j++){
                basenum *= 26;
            }
            result += (basenum * GetValue(a[i]));
        }
        return result;
    }
}
