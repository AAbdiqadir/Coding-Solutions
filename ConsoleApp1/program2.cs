using System;

namespace HelloWorld
{
    public class Solution2
    {
        public string LongestPalindrome(string s)
        {
            if (s.Equals(null) || s.Length < 1)
            {return "";}
            
            int start = 0;
            int end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = Expand(s, i, i);
                int len2 = Expand(s, i , i +1);

                int max = Math.Max(len1, len2);

                
                if (max > end-start)
                {
                    
                    start = i - ((max-1) / 2);
                    end = i + (max / 2);
                }


            }
            
            return s.Substring(start, end - start + 1);
        }
        public int Expand(string s, int left, int right)
        {

            
            if (s.Equals(null) || left > right)
            {return 0;}

            while (left>= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            
            return (right - left) - 1;
        }

        
        


    }
}