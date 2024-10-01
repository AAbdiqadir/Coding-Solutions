// See https://aka.ms/new-console-template for more information


using HelloWorld;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {

        int i = 0, j = 0;

        int max_value = 0;

        List<Char> firstlist = new List<Char>();
        while (j < s.Length)
        {

            if (!firstlist.Contains(s[j]))
            {
                firstlist.Add(s[j]);
                j++;

                max_value = Math.Max((j - i) , max_value);
            }

            else
            {
                firstlist.Remove(s[i]);
                i++;
            }

        }

        return max_value;


    }
    
   
}
    
    
        
   


    

    


