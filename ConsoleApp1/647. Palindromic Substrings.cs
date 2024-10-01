namespace HelloWorld;

public class Solution4 {
    
    public string CountSubstrings(string s)
    {
        if (s.Equals(null) || s.Length < 1)
        {return "";}
        
        int start = 0;
        int end = 0;
        int start2 = 0;
        int end2 = 0;

        if (s.Equals(null) || s.Length < 1)
            return "";
        for (int i = 0; i < s.Length; i++)
        {
            int len1 = Expand(s, i, i);
            int len2 = Expand(s, i, i + 1);
            
            // int max = Math.Max(len1, len2);
            
            if (len1 > end-start )
            {
                start = i - ((len1-1) / 2);
                end = i + (len1 / 2);
            }
            
            Console.WriteLine(s.Substring(start, end - start +1));
            
            
        }
        
        
        
        return "";

    }

    public int Expand(string s, int left, int right)
    {
        if (s.Equals(null) || left > right)
        {return 0;}
    

        List<string> list = new List<string>();
        while (left >=0 && right < s.Length && s[left] == s[right])
        {
            
            left--;
            right++;
            
        }
        
        return (right - left) -1;


    }

    
    


}